using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PosLibrary.Models;
using PosLibrary.Interfaces;
using PosLibrary.Data;
using Microsoft.EntityFrameworkCore;
namespace PosLibrary.Repositories;

public class UserRepository : IUserRepository
{

    public User? ValidateUser(string username, string password)
    {
        using var db = new Context();
        return db.Users
            .AsNoTracking()
            .SingleOrDefault(u => u.Username == username && u.Password == password);
    }
}
