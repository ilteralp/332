using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MongoDB.Bson.Serialization.Attributes;

namespace Domain
{
    public class CourseModel
    {
        [BsonId]
        public string _id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public string Place { get; set; }
    }
}
