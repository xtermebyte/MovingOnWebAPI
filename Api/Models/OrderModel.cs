using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api.Models
{
    public class OrderModel : BaseModel
    {
        [BsonElement("oitems")]
        public List<OrderItem> ItemList { get; set; }
    }

public class OrderItem
{
        [BsonElement("itemid")]
        public int ItemId { get; set; }

        [BsonElement("price")]
        public double Price { get; set; }

        [BsonElement("qty")]
        public int Qty { get; set; }
}
}