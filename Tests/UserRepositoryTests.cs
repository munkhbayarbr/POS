using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using PosLibrary.Data;
using PosLibrary.Models;
using PosLibrary.Repositories.RepositoryImp;

namespace PosLibrary.Tests
{
    [TestClass]
    public class UserRepositoryTests
    {
        private Context _context;
        private UserRepository _userRepo;

        [TestInitialize]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<Context>()
               .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            _context = new Context(options);

            // Seed data
            _context.Users.AddRange(
                new User { Id = 1, Username = "manager", Password = "manager123", Role = "Manager" },
                new User { Id = 2, Username = "cashier", Password = "guest", Role = "Cashier" }
            );
            _context.SaveChanges();

            _userRepo = new UserRepository(_context);
        }

        //Zuv hereglegcheer nevtreh test
        [TestMethod]
        public async Task CorrectUser()
        {
            var user = await _userRepo.ValidateUser("manager", "manager123");

            Assert.IsNotNull(user);
            Assert.AreEqual("Manager", user.Role);
        }
        // buruu password -r nevtrekh test
        [TestMethod]
        public async Task UserWithWrongPass()
        {
            var user = await _userRepo.ValidateUser("manager", "wrongpass");

            Assert.IsNull(user);
        }
        // buruu username -r nevtrekh test
        [TestMethod]
        public async Task NonUser()
        {
            var user = await _userRepo.ValidateUser("notexists", "1234");

            Assert.IsNull(user);
        }

        [TestCleanup]
        public void Cleanup()
        {
            _context.Dispose();
        }
    }
}
