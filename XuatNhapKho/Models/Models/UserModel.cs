﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class UserModel : BaseModel
    {

        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public System.Guid RoleID { get; set; }
        public UserModel()
        {

        }
        public UserModel(string username, string password, string firstName, string lastName)
        {
            Username = username;
            this.Password = password;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.RoleID = Guid.NewGuid();
        }
    }
}
