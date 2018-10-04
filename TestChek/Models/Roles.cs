using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestChek.Models
{
    public static class Roles
    {
        public const string CanOrderTests = "CanOrderTests";
        public const string CanViewOwnTests = "CanViewOwnTests";
        public const string CanViewOrOrderTests = CanOrderTests + "," + CanViewOwnTests;

    }
}