﻿using AspNetCore.Identity.Mongo.Model;
using System;

namespace QuizManager.Admin.Models
{
    public class MongoIdentityUser : MongoUser
    {
        public string SubjectId { get; set; } = Guid.NewGuid().ToString();
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
    }
}
