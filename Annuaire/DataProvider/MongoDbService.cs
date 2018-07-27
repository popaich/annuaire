using DataProvider;
using DataProvider.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using MongoDB.Driver.Linq;

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


        public IEnumerable<Etablissement> GetEtablissementsCommune(string depet, string comet)
        {
            var collection = Db.GetCollection<Etablissement>("sirene");

            var query =
                collection.AsQueryable<Etablissement>()
                .Where(e => e.depet == depet & e.comet == comet)
                .Select(e => e);

            return query.ToEnumerable();
        }

    }
}
