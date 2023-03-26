using FichasAndDragons.Comum.Configs.Interfaces;
using MongoDB.Driver;

namespace FichasAndDragons.Comum.Configs
{
    public class MongoDatabaseConfiguration : IMongoDatabaseConfiguration
    {
        public IMongoClient? MongoClient { get; set; }
        public IMongoDatabase? MongoDatabase { get; set; }

        public MongoDatabaseConfiguration ConfigureClient(string connectionString)
        {
            MongoClient = new MongoClient(connectionString);
            return this;
        }

        public MongoDatabaseConfiguration ConfigureDatabaseName(string databaseName)
        {
            if (MongoClient == null)
                throw new Exception("Client não configurado.");

            MongoDatabase = MongoClient.GetDatabase(databaseName);
            return this;
        }
    }
}
