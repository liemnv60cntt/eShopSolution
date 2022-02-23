using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Application.Catalog.Products.Dtos
{
    public class ProductCreateRequest
    {
        //Dtos - Data transfer objects
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
