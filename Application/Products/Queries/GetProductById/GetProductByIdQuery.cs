using Application.Common.Interfaces;
using AutoMapper;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Products.Queries.GetProductById
{
    public class GetProductByIdQuery : IRequest<ProductDto>
    {
        public Guid Id { get; set; }
    }

    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, ProductDto>
    {
        private readonly IMapper _mapper;
        private readonly IApplicationCosmosDbContext _context;

        public GetProductByIdQueryHandler
        (
            IMapper mapper,
            IApplicationCosmosDbContext context
        )
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<ProductDto> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var product = await _context.Products.FindAsync(request.Id);
            return _mapper.Map<ProductDto>(product);
        }
    }
}
