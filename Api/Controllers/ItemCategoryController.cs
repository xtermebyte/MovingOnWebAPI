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
    public class ItemCategoryController : BaseRetailController<ItemCategoryModel>
    {
        public ItemCategoryController() : base("itemcategory")
        {

        }
    }
}
