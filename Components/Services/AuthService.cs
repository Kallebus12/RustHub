using EPiServer.Cms.UI.AspNetIdentity;
using Org.BouncyCastle.Crypto.Generators;
using RustHub.Components.Shared.Models;

namespace RustHub.Components.Services
{
    public class AuthService
    {
        private readonly UserRepository _userRepository;

        public AuthService(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<bool> RegisterUserAsync(string username, string password)
        {
            if (await _userRepository.GetUserByUsernameAsync(username) != null)
            {
                return false; // User already exists
            }

            var user = new UserModel
            {
                Username = username,
                Password = BCrypt.Net.BCrypt.HashPassword(password)
            };

            await _userRepository.CreateUserAsync(user);
            return true;
        }

        public async Task<UserModel> AuthenticateUserAsync(string username, string password)
        {
            var user = await _userRepository.GetUserByUsernameAsync(username);
            if (user != null && BCrypt.Net.BCrypt.Verify(password, user.Password))
            {
                return user;
            }

            return null;
        }
    }
}
