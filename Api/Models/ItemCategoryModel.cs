using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api.Models
{
    public class ItemCategoryModel : BaseModel
    {
        public ItemCategoryModel()
        {
            TableName = "itemcategory";
        }

        [BsonElement("cname")]
        public string Name { get; set; }
    }
}