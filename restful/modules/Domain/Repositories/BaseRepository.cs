using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
namespace Domain
{
    public class BaseRepository<TModel> where TModel: class
    {
        #region Protected
        protected BaseRepository(string collectionName)
        {
            Connect();
            SetCollection(collectionName);
        }

        protected static MongoDatabase db;
        protected static MongoCollection<TModel> collection;
        #endregion

        #region Private
        private static readonly string connectionString = "mongodb://178.18.195.115:27017";
        private static readonly MongoServer server = MongoServer.Create(connectionString);
        #region Methods
        private void Connect()
        {
            db = server.GetDatabase("Comp332", new MongoCredentials("admin", "scientist"));
        }

        private void SetCollection(string collectionName)
        {
            collection = db.GetCollection<TModel>(collectionName);
        }
        #endregion
        #endregion

        public IEnumerable<TModel> GetList()
        {
            return collection.AsQueryable<TModel>().ToList();
        }
    }
}
