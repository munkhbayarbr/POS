using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PosLibrary.Models;
namespace PosLibrary.Repositories.IRepository;

public  interface ICategoryRepository
{
    List<Category> GetCategories();
    Category GetCategoryById(int id);
    string AddCategory(Category category);
    string UpdateCategory(Category category);
    string DeleteCategory(int id);
}
