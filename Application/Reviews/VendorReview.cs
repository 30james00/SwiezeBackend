using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Application.Core;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Reviews
{
    public record VendorReviewQuery(Guid Id) : IRequest<ApiResult<List<ReviewDto>>>;

    public class VendorReviewQueryHandler : IRequestHandler<VendorReviewQuery, ApiResult<List<ReviewDto>>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public VendorReviewQueryHandler(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ApiResult<List<ReviewDto>>> Handle(VendorReviewQuery request,
            CancellationToken cancellationToken)
        {
            return ApiResult<List<ReviewDto>>.Success(await _context.Reviews
                .ProjectTo<ReviewDto>(_mapper.ConfigurationProvider).Where(x => x.VendorId == request.Id)
                .ToListAsync(cancellationToken));
        }
    }
}