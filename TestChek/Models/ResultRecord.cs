using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestChek.Models
{
    public class ResultRecord: TestClass
    {
        //represents the primary key "Id" from AspNetUsers table, used here as a foreign key for relational purposes
        public string Id { get; set; }
    }
}