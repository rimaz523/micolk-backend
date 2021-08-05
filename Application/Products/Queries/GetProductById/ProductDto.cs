using Application.Common.Mappings;
using Domain.Entities;
using System;

namespace Application.Products.Queries.GetProductById
{
    public class ProductDto : IMapFrom<Product>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid VendorId { get; set; }
    }
}
