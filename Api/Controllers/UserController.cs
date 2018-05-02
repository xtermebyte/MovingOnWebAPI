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
    public class UserController : BaseRetailController<UserModel>
    {
        public UserController() : base("users")
        {

        }
    }
}
