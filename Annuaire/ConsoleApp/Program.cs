using DataProvider;
using DataProvider.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using MongoDB.Driver.Linq;

namespace ConsoleApp
{
    class Program
    {
        private static MongoDbService mongoDbService;

        static void Main(string[] args)
        {
            mongoDbService = new MongoDbService("mongodb://localhost:27017", "sirene_app");
            //Test3("42","015");


            List<Etablissement> data = GetEtablissementsCommune("42", "015");

            foreach(Etablissement x in data)
            {
                Console.WriteLine($"nomen_long: {x.nomen_long}, libnj: {x.libnj}, natetab: {x.natetab}, libapet: {x.libapet}");
            }

            Console.Read();
        }
        
        public static void Test1()
        {
            var collection = mongoDbService.Db.GetCollection<BsonDocument>("sirene");

            var builder = Builders<BsonDocument>.Filter;
            var filter = builder.Eq("depet", "42") & builder.Eq("comet", "015");

            var cursor = collection.Find(filter).ToCursor();
            foreach (var document in cursor.ToEnumerable())
            {
                Console.WriteLine(document);
            }
        }

        public static void Test2()
        {
            var collection = mongoDbService.Db.GetCollection<BsonDocument>("sirene");

            var builder = Builders<BsonDocument>.Filter;
            var filter = builder.Eq("depet", "42") & builder.Eq("comet", "015");
            collection.Find(filter).ForEachAsync(document => Console.WriteLine(document));
        }

        public static void Test3(string depet, string comet)
        {
            
            var collection = mongoDbService.Db.GetCollection<Etablissement>("sirene");
            collection.Find(x => x.depet == depet && x.comet == comet).ForEachAsync(x => Console.WriteLine($"nomen_long: {x.nomen_long}, libnj: {x.libnj}, natetab: {x.natetab}, libapet: {x.libapet}"));
        }

        public static List<Etablissement> GetEtablissementsCommune(string depet, string comet)
        {
            var collection = mongoDbService.Db.GetCollection<Etablissement>("sirene");

            /* query syntax */
            //var query =
            //   from e in collection.AsQueryable<Etablissement>()
            //   where e.depet == depet & e.comet == comet
            //   select e;

            /* lambda syntax */
            var query =
                collection.AsQueryable<Etablissement>()
                .Where(e => e.depet == depet & e.comet == comet)
                .Select(e => e);

            return query.ToList();
        }




    }
}
