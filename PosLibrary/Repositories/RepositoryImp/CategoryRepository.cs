using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PosLibrary.Data;
using PosLibrary.Models;
using PosLibrary.Repositories.IRepository;
namespace PosLibrary.Repositories.RepositoryImp;

public class CategoryRepository: ICategoryRepository
{
    private readonly Context _context;
    public CategoryRepository(Context context)
    {
        _context = context;
    }

    public List<Category> GetCategories()
    {
        
        return _context.Categories.ToList();
    }
    public Category? GetCategoryById(int id)
    {
        return _context.Categories.FirstOrDefault(c => c.Id == id);
    }
    public string AddCategory(Category Category)
    {
        _context.Categories.Add(Category);
        int result = _context.SaveChanges();
        return result > 0 ? "Амжилттай." : "Амжилтгүй.";
    }

    public string DeleteCategory(int id)
    {
        var Category = _context.Categories.FirstOrDefault(p => p.Id == id);
        if (Category == null) return "Ангилал олдсонгүй";

        _context.Categories.Remove(Category);
        int result = _context.SaveChanges();
        return result > 0 ? "Амжилттай." : "Амжилтгүй.";
    }

    public string UpdateCategory(Category Category)
    {
        var existingCategory = _context.Categories.FirstOrDefault(p => p.Id == Category.Id);
        if (existingCategory == null) return "Ангилал олдсонгүй";

        existingCategory.Name = Category.Name;

        int result = _context.SaveChanges();
        return result > 0 ? "Амжилттай." : "Амжилтгүй.";
    }


}
