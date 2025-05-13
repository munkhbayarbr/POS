using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PosLibrary.Models;
using PosLibrary.Data;
using Microsoft.EntityFrameworkCore;
using PosLibrary.Repositories.IRepository;
namespace PosLibrary.Repositories.RepositoryImp;

public class UserRepository : IUserRepository
{
    private readonly Context _context;
    
    public UserRepository()
    {
        _context = new Context();
    }
    public async Task<User> ValidateUser(string username, string password)
    {
        User user = null;
        user = await _context.Users.SingleOrDefaultAsync(u => u.Username == username && u.Password == password);

        return user;
    }
}
