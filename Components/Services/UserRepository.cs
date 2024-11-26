using EPiServer.Cms.UI.AspNetIdentity;
using MongoDB.Driver;
using RustHub.Components.Shared.Models;

namespace RustHub.Components.Services
{
    public class UserRepository
    {
        private readonly IMongoCollection<UserModel> _users;

        public UserRepository(MongoDbContext context)
        {
            _users = context.Users;
        }

        public async Task<UserModel> GetUserByUsernameAsync(string email)
        {
            return await _users.Find(user => user.Username == email).FirstOrDefaultAsync();
        }

        public async Task CreateUserAsync(UserModel user)
        {
            await _users.InsertOneAsync(user);
        }
    }
}
