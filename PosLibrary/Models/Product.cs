using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosLibrary.Models;
public class Product
{
    public int Id { get; set; }

    public required string Code { get; set; }
    public required string Name { get; set; }

    public int CategoryId { get; set; }        
    public  Category Category { get; set; }    

    public decimal Price { get; set; }
    public int Stock { get; set; }
}