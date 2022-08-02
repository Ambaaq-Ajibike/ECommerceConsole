using System;
using System.Linq;
using EcommerceProject.Entities;
namespace EcommerceProject.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly EcommereContext _context;
        public UserRepository(EcommereContext context)
        {
            _context = context;
        }
        public User UpdateUser(User user)
        {
            _context.Update(user);
            _context.SaveChanges();
            return user;
        }
        public User GetUserByEmailAndPassWord(string email, string password)
        {
            return _context.Users.FirstOrDefault(x => x.Email == email && x.Password == password);
        }
        public User GetUserByEmail(string email)
        {
            return _context.Users.FirstOrDefault(x => x.Email == email);
        }
        public User GetUserById(int id)
        {
            return _context.Users.Find(id);
        }
        public bool DeleteUserByID(int id)
        {
            var deleteid = _context.Users.Find(id);
            _context.Users.Remove(deleteid);
            _context.SaveChanges();
            return true;
        }
        public User CreateUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return user;
        }
    }
}