using System;
using EcommerceProject.Entities;
namespace EcommerceProject.Repositories
{
    public interface IUserRepository
    {
         public User CreateUser(User user);
         public User UpdateUser(User user);
         public User GetUserById(int id);
         public User GetUserByEmail(string email);
         public User GetUserByEmailAndPassWord(string password, string email);
         public bool DeleteUserByID(int id);
    }
}