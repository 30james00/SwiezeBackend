using System;
using System.Threading;
using System.Threading.Tasks;
using Application.Contacts;
using Application.Core;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Products
{
    public record DetailProductQuery(Guid Id) : IRequest<ApiResult<ProductDto>>;

    public class DetailProductQueryHandler : IRequestHandler<DetailProductQuery, ApiResult<ProductDto>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public DetailProductQueryHandler(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ApiResult<ProductDto>> Handle(DetailProductQuery request, CancellationToken cancellationToken)
        {
            return ApiResult<ProductDto>.Success(
                await _context.Products.ProjectTo<ProductDto>(_mapper.ConfigurationProvider)
                    .FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken));
        }
    }
}