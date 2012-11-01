using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MongoDB.Bson.Serialization.Attributes;
using Domain.Course;
using MongoDB.Bson;
namespace Domain.User
{
    public class UserModel
    {
        [BsonId]
        public Object _id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public IList<CourseModel> Courses { get; set; }
    }
}
