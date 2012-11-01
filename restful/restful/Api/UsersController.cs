using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Domain.User;

namespace restful.Api
{
    public class UsersController : ApiController
    {
        private static readonly IUserRepository repository = new UserRepository();

        public UserModel GetByName(string name)
        {
            return repository.GetUserByName(name);
        }
    }
}
