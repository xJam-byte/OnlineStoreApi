using OnlineStore.Model;
using Services.interFaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Impl
{
  public class ProductService : IProductInterFace
  {
    public async Task<Product> GetProduct()
    {
      return new Product()
      {
        Id = 1,
        Name = "product 1",
        Price = 100,
        Description = "new laptop with best price"
      };

    }

    public async Task<List<Product>> GetProducts()
    {
      return new List<Product>(){
        new Product()
        {
          Id = 1,
          Name = "product 1",
          Price = 100,
          Description = "new laptop with best price"
        },
        new Product()
        {
          Id = 1,
          Name = "product 2",
          Price = 200,
          Description = "new laptop2 with best price"
        }
      };
    }
  }
}
