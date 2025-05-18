using PosLibrary.Data;
using PosLibrary.Models;
using PosLibrary.Repositories.IRepository;
using System.Collections.Generic;
using System.Linq;

namespace PosLibrary.Repositories.RepositoryImp
{
    public class ProductRepository : IProductRepository
    {
        private readonly Context _context;

        public ProductRepository()
        {
            _context = new Context();
        }

        public List<Product> GetProducts()
        {
            return _context.Products.ToList();
        }

        public Product? GetProductById(int id)
        {
            return _context.Products.FirstOrDefault(p => p.Id == id);
        }

        public string AddProduct(Product product)
        {
            _context.Products.Add(product);
            int result = _context.SaveChanges();
            return result > 0 ? "Амжилттай." : "Амжилтгүй.";
        }

        public string DeleteProduct(int id)
        {
            var product = _context.Products.FirstOrDefault(p => p.Id == id);
            if (product == null) return "Бараа олдсонгүй";

            _context.Products.Remove(product);
            int result = _context.SaveChanges();
            return result > 0 ? "Амжилттай." : "Амжилтгүй.";
        }

        public string UpdateProduct(Product product)
        {
            var existingProduct = _context.Products.FirstOrDefault(p => p.Id == product.Id);
            if (existingProduct == null) return "Бараа олдсонгүй";

            existingProduct.Name = product.Name;
            existingProduct.Price = product.Price;
            existingProduct.Stock = product.Stock;
            existingProduct.Code = product.Code;
            existingProduct.CategoryId = product.CategoryId;

            if (product.ImageData != null && product.ImageData.Length > 0)
            {
                existingProduct.ImageData = product.ImageData;
            }

            int result = _context.SaveChanges();
            return result > 0 ? "Амжилттай." : "Амжилтгүй.";
        }
    }
}
