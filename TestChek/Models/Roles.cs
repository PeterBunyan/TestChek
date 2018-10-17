using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestChek.Models
{
    public static class Roles
    {
        //Provider role, capable of ordering tests on patients
        public const string CanOrderTests = "CanOrderTests";
        //User/Patient role, only capable of viewing own test results
        public const string CanViewOwnTests = "CanViewOwnTests";
        //string used to demarcate areas where both of the previous roles have access
        public const string CanViewOrOrderTests = CanOrderTests + "," + CanViewOwnTests;

    }
}