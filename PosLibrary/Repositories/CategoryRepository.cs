using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PosLibrary.Data;
using PosLibrary.Models;
namespace PosLibrary.Repositories;

public class CategoryRepository
{
    public List<Category> GetCategories()
    {
        using var db = new Context();
        return db.Categories.ToList();
    }
}
