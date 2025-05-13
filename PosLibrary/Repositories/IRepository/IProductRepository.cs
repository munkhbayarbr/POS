using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PosLibrary.Models;
namespace PosLibrary.Repositories.IRepository;

public interface IProductRepository
{
    
    List<Product> GetProducts();
    Product GetProductById(int id);
    string  AddProduct(Product product);
    string UpdateProduct(Product product);
    string DeleteProduct(int id);
}
