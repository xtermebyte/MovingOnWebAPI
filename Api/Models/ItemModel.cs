using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api.Models
{
    public class ItemModel: BaseModel
    {
        public ItemModel()
        {
            TableName = "item";
        }

        [BsonElement("iname")]
        public string Name { get; set; }

        [BsonElement("icat")]
        public int icat { get; set; }

        [BsonElement("iprice")]
        public double iprice { get; set; }
    }
}