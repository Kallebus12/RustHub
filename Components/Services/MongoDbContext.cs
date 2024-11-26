using EPiServer.Cms.UI.AspNetIdentity;
using MongoDB.Driver;
using RustHub.Components.Shared.Models;

namespace RustHub.Components.Services
{
    public class MongoDbContext
    {
        private readonly IMongoDatabase _database;

        public MongoDbContext(IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("MongoDb");
            var client = new MongoClient(connectionString);
            _database = client.GetDatabase("RustHub");
        }

        public IMongoCollection<UserModel> Users => _database.GetCollection<UserModel>("Users");
    }
}
