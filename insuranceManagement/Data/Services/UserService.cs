using insuranceManagement.Data.Models;
using insuranceManagement.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace insuranceManagement.Data.Services
{
    public class UserService
    {
        private AppDbContext _context;
        public UserService(AppDbContext context)
        {
            _context = context;
        }

        public void AddUser(UserVM user)
        {
            var _user = new User()
            {
                name = user.name,
                address = user.address,
                email = user.email,
                password = user.password,
                age = user.age,
                phone = user.phone,
                role = user.role,
                dob = user.dob
            };
            _context.Users.Add(_user);
            _context.SaveChanges();
        }

        public List<User> GetAllUser() => _context.Users.ToList();

        public User GetUserById(int userId) => _context.Users.FirstOrDefault(n => n.id == userId);
    }
}
