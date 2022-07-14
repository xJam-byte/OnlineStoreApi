using OnlineStore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Repo.Interfaces
{
  public interface IProductRepository
  {
    Task<Product> GetProductById(int id);
    Task<List<Product>> GetProducts(int? top = null);//? - может и принимать и не принимать
    Task<int> InsertProduct(Product product);
    Task UpdateProduct(int id);
    Task DeleteProduct(int id);

  }
}
