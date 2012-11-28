using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace User
{
    public class UserModel
    {
        public string _id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public IList<CourseModel> Courses { get; set; }
    }
}
