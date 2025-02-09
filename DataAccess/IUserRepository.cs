using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DataAccess
{
    public interface IUserRepository
    {
        Task<List<User>> GetAllUsers(); 
        Task<List<User>> GetUserByTerm(string term);
        Task<bool> AddUser(User user);
        Task<bool> UpdateUser(User user); 
        Task<bool> DeleteUser(string userId); 
        //Task<User> GetUserByUsernameAsync(string username);
        Task<bool> ValidatePassword(string username, string inputPassword);
        //Task<bool> UpdateUserPhoneAsync(string username, string phone);
        //Task<bool> UpdateUserRoleAsync(string username, string role);
        //Task<bool> UpdateUserPasswordAsync(string username, string password);
        //Task<string> GenerateNewUserIDAsync();
        Task<string> GetUserRole(string username, string password);
    }
}
