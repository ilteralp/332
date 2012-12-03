using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Domain.User;
namespace restfulapi.Api
{
    public class UsersController : ApiController
    {
        IUserRepository repository;
        public UsersController()
        {
            repository = new UserRepository();
        }
        public UserModel GetUser(string id)
        {
            return repository.GetUserByName(id);
        }

        public IEnumerable<UserModel> GetList()
        {
            return repository.GetList();
        }
    }
}
