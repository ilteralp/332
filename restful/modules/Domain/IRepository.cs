using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MongoDB.Bson;

namespace Domain
{
    public interface IRepository<TModel> where TModel: class
    {
        IEnumerable<TModel> GetList();
    }
}
