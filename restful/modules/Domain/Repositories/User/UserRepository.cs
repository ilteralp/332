using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MongoDB.Driver.Linq;
namespace Domain.User
{
    public class UserRepository:BaseRepository<UserModel>,IUserRepository
    {
        public UserRepository() : base("Users") { }

        public UserModel GetUserByName(string name)
        {
            return collection.AsQueryable<UserModel>().Where(_ => _.Name.Equals(name)).FirstOrDefault();
        }
    }
}
