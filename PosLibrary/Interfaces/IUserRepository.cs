using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PosLibrary.Models;
namespace PosLibrary.Interfaces;

public interface IUserRepository
{
    User?  ValidateUser(string username, string password);
}
