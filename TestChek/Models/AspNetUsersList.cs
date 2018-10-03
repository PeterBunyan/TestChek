using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestChek.Models
{
    public class AspNetUsersList
    {
        private ModelDBContext _context = new ModelDBContext();

        public List<AspNetUser> GetAspNetUsers()
        {
           
            return _context.AspNetUsers.ToList();
        }
    }
}