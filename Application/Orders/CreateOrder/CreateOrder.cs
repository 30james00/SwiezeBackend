using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Application.Core;
using Application.Services;
using AutoMapper;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Orders.CreateOrder
{
    public class CreateOrderCommand : IRequest<ApiResult<List<OrderDto>>>
    {
        public string CouponCode { get; set; }
    }

    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, ApiResult<List<OrderDto>>>
    {
        private readonly DataContext _context;
        private readonly IAccountService _accountService;
        private readonly ICouponService _couponService;
        private readonly IMapper _mapper;

        public CreateOrderCommandHandler(DataContext context, IAccountService accountService,
            ICouponService couponService, IMapper mapper)
        {
            _context = context;
            _accountService = accountService;
            _couponService = couponService;
            _mapper = mapper;
        }

        public async Task<ApiResult<List<OrderDto>>> Handle(CreateOrderCommand request,
            CancellationToken cancellationToken)
        {
            //check account
            var account = await _accountService.GetAccountInfo();
            if (account.AccountType == AccountType.Vendor) return ApiResult<List<OrderDto>>.Forbidden();


            //get current Cart
            var cart = await _context.Carts.Where(x => x.ClientId == account.Id).Include(x => x.Product)
                .ToListAsync(cancellationToken);
            //group CartItems by Vendor
            var groupedCart = cart.GroupBy(x => x.Product.VendorId);

            Coupon coupon = null;

            //check Coupon
            if (request.CouponCode != null)
            {
                coupon = await _context.Coupons.Where(x => x.Code == request.CouponCode)
                    .FirstOrDefaultAsync(cancellationToken);
                if (coupon == null || !_couponService.IsValid(coupon))
                    return ApiResult<List<OrderDto>>.Failure("Provided Coupon is invalid");
                if (cart.All(x => x.Product.VendorId != coupon.VendorId))
                    return ApiResult<List<OrderDto>>.Failure("Provided Coupon does not apply to any Product");
            }

            var orders = new List<Order>();

            foreach (var vendor in groupedCart)
            {
                var order = new Order
                {
                    ClientId = account.Id,
                    VendorId = vendor.Key,
                    OrderDate = DateTime.Now,
                };

                orders.Add(order);

                var items = new List<OrderItem>();

                var checkCoupon = false;
                if (coupon != null)
                {
                    checkCoupon = coupon.VendorId == vendor.Key;
                    if (!_couponService.IsValid(coupon)) checkCoupon = false;
                    if (checkCoupon && coupon.AmountOfUses != null) coupon.AmountOfUses--;
                }

                //check Product availability
                foreach (var cartItem in vendor)
                {
                    if (cartItem.Amount > cartItem.Product.Stock)
                        return ApiResult<List<OrderDto>>.Failure("One of Products is unavailable");

                    //add Product to Order
                    items.Add(new OrderItem
                    {
                        Order = order,
                        ProductId = cartItem.ProductId,
                        Value = checkCoupon
                            ? cartItem.Product.Value * (100 - coupon.Amount) / 100
                            : cartItem.Product.Value,
                        Amount = cartItem.Amount,
                    });
                }

                await _context.Orders.AddAsync(order, cancellationToken);
                await _context.OrderItems.AddRangeAsync(items, cancellationToken);
            }

            //clear Cart
            var toDelete = await _context.Carts.Where(x => x.ClientId == account.Id).ToListAsync(cancellationToken);
            _context.Carts.RemoveRange(toDelete);

            var result = await _context.SaveChangesAsync(cancellationToken) > 0;

            var mappedOrders = _mapper.Map<List<OrderDto>>(orders);

            return result
                ? ApiResult<List<OrderDto>>.Success(mappedOrders)
                : ApiResult<List<OrderDto>>.Failure("Failed to add Order");
        }
    }
}