using DataAccess;
using Model;

namespace Business
{
    public class UserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<List<User>> GetAllUsersAsync()
        {
            return await _userRepository.GetAllUsers();
        }

        public async Task<bool> AddUserAsync(User user)
        {
            return await _userRepository.AddUser(user);
        }

        public async Task<bool> UpdateUserAsync(User user)
        {
            return await _userRepository.UpdateUser(user);
        }

        public async Task<bool> DeleteUserAsync(string userId)
        {
            return await _userRepository.DeleteUser(userId);
        }

        //public async Task<bool> UpdateUserPhoneAsync(string username, string phone)
        //{
        //    return await _userRepository.UpdateUserPhoneAsync(username, phone);
        //}

        //public async Task<bool> UpdateUserRoleAsync(string username, string role)
        //{
        //    return await _userRepository.UpdateUserRoleAsync(username, role);
        //}

        //public async Task<bool> UpdateUserPasswordAsync(string username, string password)
        //{
        //    return await _userRepository.UpdateUserPasswordAsync(username, password);
        //}

        //public async Task<string> GenerateNewUserIDAsync()
        //{
        //    return await _userRepository.GenerateNewUserIDAsync();
        //}
        public async Task<string> GetUserRoleAsync(string username, string password)
        {
            return await _userRepository.GetUserRole(username, password);
        }
        public async Task<List<User>> GetUsersByTermAsync(string term)
        {
            return await _userRepository.GetUserByTerm(term);
        }
    }
}
