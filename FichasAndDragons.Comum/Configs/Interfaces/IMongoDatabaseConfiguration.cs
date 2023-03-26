using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichasAndDragons.Comum.Configs.Interfaces
{
    public interface IMongoDatabaseConfiguration
    {
        IMongoClient MongoClient { get; set; }
        IMongoDatabase MongoDatabase { get; set; }
    }
}
