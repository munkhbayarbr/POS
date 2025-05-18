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
    public class CategoryRepositoryTests
    {
        private Context _context;
        private CategoryRepository _categoryRepo;

        [TestInitialize]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<Context>()
                .UseInMemoryDatabase(databaseName: System.Guid.NewGuid().ToString())
                .Options;

            _context = new Context(options);

            _context.Categories.AddRange(
                new Category { Id = 1, Name = "Food" },
                new Category { Id = 2, Name = "Drinks" }
            );
            _context.SaveChanges();

            _categoryRepo = new CategoryRepository(_context);
        }
        //Category -n getALL -g  shalgana
        [TestMethod]
        public void GetCategoriesCheck()
        {
            var result = _categoryRepo.GetCategories();
            Assert.AreEqual(2, result.Count);
        }

        // Category-n id-r zuv category irehiig shalgana
        [TestMethod]
        public void GetCategoryByIdCheck()
        {
            var category = _categoryRepo.GetCategoryById(1);
            Assert.IsNotNull(category);
            Assert.AreEqual("Food", category.Name);
        }

        // Shine category vvsgeh uildliig shalgana
        [TestMethod]
        public void AddCategoryCheck()
        {
            var result = _categoryRepo.AddCategory(new Category { Name = "Snacks" });
            Assert.AreEqual("Амжилттай.", result);

            var all = _categoryRepo.GetCategories();
            Assert.AreEqual(3, all.Count);
        }

        //Category Update-g shalgana
        [TestMethod]
        public void UpdateCategoryCheck()
        {
            var updated = new Category { Id = 1, Name = "Fresh Food" };
            var result = _categoryRepo.UpdateCategory(updated);
            Assert.AreEqual("Амжилттай.", result);

            var category = _categoryRepo.GetCategoryById(1);
            Assert.AreEqual("Fresh Food", category.Name);
        }

        //Category ustgah uildel -g shalgana
        [TestMethod]
        public void DeleteCategoryCheck()
        {
            var result = _categoryRepo.DeleteCategory(2);
            Assert.AreEqual("Амжилттай.", result);

            var remaining = _categoryRepo.GetCategories();
            Assert.AreEqual(1, remaining.Count);
        }
        //Baihgui category-g ustah uildel 
        [TestMethod]
        public void DeleteFalseCategory()
        {
            var result = _categoryRepo.DeleteCategory(999);
            Assert.AreEqual("Ангилал олдсонгүй", result);
        }

        [TestCleanup]
        public void Cleanup()
        {
            _context.Dispose();
        }
    }
}
