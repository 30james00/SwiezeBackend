using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Application.Core;
using Application.Services;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Coupons
{
    public record ListCouponQuery : IRequest<ApiResult<List<CouponDto>>>;

    public class ListCouponQueryHandler : IRequestHandler<ListCouponQuery, ApiResult<List<CouponDto>>>
    {
        private readonly DataContext _context;
        private readonly IAccountService _accountService;
        private readonly IMapper _mapper;

        public ListCouponQueryHandler(DataContext context, IAccountService accountService, IMapper mapper)
        {
            _context = context;
            _accountService = accountService;
            _mapper = mapper;
        }

        public async Task<ApiResult<List<CouponDto>>> Handle(ListCouponQuery request, CancellationToken cancellationToken)
        {
            var account = await _accountService.GetAccountInfo();
            if (account.AccountType == AccountType.Client) return ApiResult<List<CouponDto>>.Forbidden();

            var coupons = await _context.Coupons.Where(x => x.VendorId == account.Id)
                .ProjectTo<CouponDto>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken);
            
            return ApiResult<List<CouponDto>>.Success(coupons);
        }
    }
}