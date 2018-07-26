using DataProvider;
using MongoDB.Bson;
using MongoDB.Driver;
using System;

namespace ConsoleApp
{
    class Program
    {
        private static MongoDbService mongoDbService;

        static void Main(string[] args)
        {
            mongoDbService = new MongoDbService("mongodb://localhost:27017", "sirene_app");

            var collection = mongoDbService.Db.GetCollection<BsonDocument>("sirene");

            //equality filter
            var filter = Builders<BsonDocument>.Filter.Eq("depet", "42");

            var cursor = collection.Find(filter).ToCursor();
            foreach (var document in cursor.ToEnumerable())
            {
                Console.WriteLine(document);
            }

            Console.Read();
        }


    }
}
