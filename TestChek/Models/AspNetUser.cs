﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestChek.Models
{
    public class AspNetUser
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public string PhoneNumber { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}