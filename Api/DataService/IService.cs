using Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api.DataService
{
    public interface IService<T> where T: BaseModel
    {
        List<T> Get();

        T Get(int id);

        void Update(T data);
    }
}