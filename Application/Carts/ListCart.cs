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

namespace Application.Carts
{
    public record ListCartQuery() : IRequest<ApiResult<List<CartDto>>>;

    public class ListCartQueryHandler : IRequestHandler<ListCartQuery, ApiResult<List<CartDto>>>
    {
        private readonly DataContext _context;
        private readonly IAccountService _accountService;
        private readonly IMapper _mapper;

        public ListCartQueryHandler(DataContext context, IAccountService accountService, IMapper mapper)
        {
            _context = context;
            _accountService = accountService;
            _mapper = mapper;
        }

        public async Task<ApiResult<List<CartDto>>> Handle(ListCartQuery request, CancellationToken cancellationToken)
        {
            var account = await _accountService.GetAccountInfo();
            if (account.AccountType == AccountType.Vendor)
                return ApiResult<List<CartDto>>.Failure("User is not a Client");

            return ApiResult<List<CartDto>>.Success(await _context.Carts
                .Where(x => x.ClientId == account.Id).ProjectTo<CartDto>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken));
        }
    }
}