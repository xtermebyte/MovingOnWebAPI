using Api.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api.DataService
{
    public class BaseRetailService<T> : IService<T> where T : BaseModel
    {
        private string TableName { get; set; }
        public BaseRetailService(string tableName)
        {
            //var connectionString = "mongodb://localhost:27017";

            //var client = new MongoClient(connectionString);
            //var db = client.GetDatabase("Retail");

            TableName = tableName;
        }

        public List<T> Get()
        {
            var connectionString = "mongodb://localhost:27017";

            var client = new MongoClient(connectionString);
            var db = client.GetDatabase("Retail");
            var col = db.GetCollection<T>(TableName);
            var data = col.Find<T>(FilterDefinition<T>.Empty).ToList();

            return data;
        }

        public T Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(T data)
        {
            var connectionString = "mongodb://localhost:27017";

            var client = new MongoClient(connectionString);
            var db = client.GetDatabase("Retail");
            var col = db.GetCollection<T>(TableName);
            col.InsertOne(data);
        }
    }
}