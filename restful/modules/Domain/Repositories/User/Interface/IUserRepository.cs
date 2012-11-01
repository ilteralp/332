using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.User
{
    public interface IUserRepository:IRepository<UserModel>
    {
        UserModel GetUserByName(string name);
    }
}
