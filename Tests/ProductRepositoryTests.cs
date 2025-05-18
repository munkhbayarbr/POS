using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.EntityFrameworkCore;
using PosLibrary.Data;
using PosLibrary.Models;
using PosLibrary.Repositories.RepositoryImp;
using System.Collections.Generic;
using System.Linq;

namespace PosLibrary.Tests
{
    [TestClass]
    public class ProductRepositoryTests
    {
        private Context _context;
        private ProductRepository _productRepo;

        [TestInitialize]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<Context>()
                .UseInMemoryDatabase(databaseName: System.Guid.NewGuid().ToString())
                .Options;

            _context = new Context(options);

            // Seed category
            var category = new Category { Id = 1, Name = "Test" };
            _context.Categories.Add(category);

            // Seed products
            _context.Products.AddRange(
                new Product { Id = 1, Name = "Apple", Code = "A001", Price = 1.5m, Stock = 10, CategoryId = 1 },
                new Product { Id = 2, Name = "Banana", Code = "B001", Price = 2.0m, Stock = 5, CategoryId = 1 }
            );
            _context.SaveChanges();

            _productRepo = new ProductRepository(_context);
        }
        
        //Product -n toog shalgana
        [TestMethod]
        public void ProductCountCheck()
        {
            var products = _productRepo.GetProducts();
            Assert.AreEqual(2, products.Count);
        }
        //Product -n id-r zuv product irehiig shalgana
        [TestMethod]
        public void GetProdByIdCheck()
        {
            var product = _productRepo.GetProductById(1);
            Assert.IsNotNull(product);
            Assert.AreEqual("Apple", product.Name);
        }
        // product nemeh uildel -g shalgana
        [TestMethod]
        public void addProductCheck()
        {
            var newProduct = new Product
            {
                Name = "Orange",
                Code = "O001",
                Price = 3.0m,
                Stock = 20,
                CategoryId = 1
            };

            var result = _productRepo.AddProduct(newProduct);
            Assert.AreEqual("Амжилттай.", result);

            var all = _productRepo.GetProducts();
            Assert.AreEqual(3, all.Count);
        }
        // product update hiih uildliig shalgana
        [TestMethod]
        public void UpdateProductCheck()
        {
            var updatedProduct = new Product
            {
                Id = 1,
                Name = "Green Apple",
                Code = "A001",
                Price = 1.8m,
                Stock = 12,
                CategoryId = 1
            };

            var result = _productRepo.UpdateProduct(updatedProduct);
            Assert.AreEqual("Амжилттай.", result);

            var product = _productRepo.GetProductById(1);
            Assert.AreEqual("Green Apple", product.Name);
        }

        // product ustgah uildliig shalgana
        [TestMethod]
        public void DeleteProductCheck()
        {
            var result = _productRepo.DeleteProduct(1);
            Assert.AreEqual("Амжилттай.", result);

            var product = _productRepo.GetProductById(1);
            Assert.IsNull(product);
        }

        [TestCleanup]
        public void Cleanup()
        {
            _context.Dispose();
        }
    }
}
