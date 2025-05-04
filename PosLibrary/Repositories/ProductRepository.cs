using PosLibrary.Data;
using PosLibrary.Models;
using System.Collections.Generic;
using System.Linq;

namespace PosLibrary.Repositories;

public class ProductRepository
{
    public List<Product> GetProducts()
    {
        using var db = new Context();
        return db.Products.ToList();
    }
}
