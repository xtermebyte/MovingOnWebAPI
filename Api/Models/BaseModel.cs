using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api.Models
{
    public class BaseModel
    {
        [BsonElement("_id")]
        public int Id { get; set; }

        [BsonIgnore]
        public string TableName { get; set; }
    }
}