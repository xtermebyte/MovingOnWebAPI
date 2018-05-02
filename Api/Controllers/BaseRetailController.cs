using Api.DataService;
using Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Api.Controllers
{
    public abstract class BaseRetailController<T> : ApiController where T: BaseModel
    {
        public string TableName { get; set; }

        public BaseRetailController(string tableName)
        {
            TableName = tableName;
        }
        
        // GET: api/BaseRetail
        public IEnumerable<T> Get()
        {
            //OrderModel data = new OrderModel() { Id = 3, ItemList = new List<OrderItem>() { new OrderItem() { ItemId = 5, Price = 3.0, Qty = 2 }, new OrderItem() { ItemId = 1, Price = 1.5, Qty = 2 } } };
            //(new RetalService<OrderModel>() { TableName="order" }).Update(data);
            return (new BaseRetailService<T>(TableName)).Get();
        }

        // GET: api/BaseRetail/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/BaseRetail
        public void Post([FromBody]T value)
        {
            (new BaseRetailService<T>(TableName)).Update(value);
        }

        // PUT: api/BaseRetail/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/BaseRetail/5
        public void Delete(int id)
        {
        }
    }
}
