using MongoDB.Bson;
using MongoDB.Driver;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("sirene_app");
            var collection = database.GetCollection<BsonDocument>("sirene");

            //equality filter
            var filter = Builders<BsonDocument>.Filter.Eq("depet", "42");

            var cursor = collection.Find(filter).ToCursor();
            foreach (var document in cursor.ToEnumerable())
            {
                Console.WriteLine(document);
            }


            Console.WriteLine("new feature");

            Console.Read();
        }
    }
}
