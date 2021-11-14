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

namespace Application.Orders.AddOrder
{
    public record AddOrderCommand : IRequest<ApiResult<List<OrderDto>>>;

    public class AddOrderCommandHandler : IRequestHandler<AddOrderCommand, ApiResult<List<OrderDto>>>
    {
        private readonly DataContext _context;
        private readonly IAccountService _accountService;
        private readonly IMapper _mapper;

        public AddOrderCommandHandler(DataContext context, IAccountService accountService, IMapper mapper)
        {
            _context = context;
            _accountService = accountService;
            _mapper = mapper;
        }

        public async Task<ApiResult<List<OrderDto>>> Handle(AddOrderCommand request,
            CancellationToken cancellationToken)
        {
            //check account
            var account = await _accountService.GetAccountInfo();
            if (account.AccountType == AccountType.Vendor) return ApiResult<List<OrderDto>>.Forbidden();

            //get current Cart
            var cart = _context.Carts.Where(x => x.ClientId == account.Id).Include(x => x.Product)
                .AsEnumerable().GroupBy(x => x.Product.VendorId);

            var orders = new List<Order>();

            foreach (var vendor in cart)
            {
                var order = new Order
                {
                    ClientId = account.Id,
                    VendorId = vendor.Key,
                    OrderDate = DateTime.Now,
                };

                orders.Add(order);

                var items = new List<OrderItem>();

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
                        Value = cartItem.Product.Value,
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