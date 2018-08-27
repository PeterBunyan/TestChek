﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestChek.Models
{
    public class PatientRecord: TestClass
    {
        public string Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string orderingPhysician { get; set; }
        public string medRecNumber { get; set; }
        public DateTime timeofTest { get; set; }
        public List<TestClass> myTestResults { get; set; }
    }
}