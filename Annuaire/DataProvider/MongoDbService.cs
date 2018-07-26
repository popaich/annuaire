using DataProvider.Models;
using MongoDB.Driver;
using System.Collections.Generic;

namespace DataProvider
{
    public class MongoDbService
    {
        public readonly IMongoDatabase Db;

        public MongoDbService(string ConnectionString, string Database)
        {
            var client = new MongoClient(ConnectionString);
            Db = client.GetDatabase(Database);
        }


        public IEnumerable<Etablissement> GetEtablissementsCommune(string depet)
        {
            return new List<Etablissement>();
        }

    }
}
