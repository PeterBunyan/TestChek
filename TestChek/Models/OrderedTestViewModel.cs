using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TestChek.Models
{
    public class OrderedTestViewModel
    {
        //Primary Key, though model does not currently exist in DB
        [Key]
        public int Id { get; set; }
        //Stores a list of AspNetUser, a list of "patients" that registered for site access
        public List<AspNetUser> patientList { get; set; }
        //Test in Drop-down menu of view
        public string CBC { get; set; }
        //Test in Drop-down menu of view
        public string BMP { get; set; }
        //Test in Drop-down menu of view
        public string UA { get; set; }
    }
}