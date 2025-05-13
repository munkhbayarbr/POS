using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PosLibrary.Models;
namespace PosLibrary.Repositories.IRepository;

public interface IUserRepository
{
    Task<User> ValidateUser(string username, string password);
}
