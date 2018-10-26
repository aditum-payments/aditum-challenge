using MongoDbGenericRepository;

namespace Aditum.Catalog.Repository
{
    /// <summary>
    /// MongoDB abstraction implementarion.
    /// </summary>
    internal class MongoRepository : BaseMongoRepository
    {
        public MongoRepository(string connectionString, string databaseName)
           : base(connectionString, databaseName) { }
    }
}
