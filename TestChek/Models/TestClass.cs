using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestChek.Models
{
    public class TestClass
    {
        //used to increment 'testId' in constructor every time object is instantiated
        private static int _IdIncrementer = 0;

        //represents the unique ID of each test ordered (just incremented here for the sake of simplicity)
        //[Key]
        public int testId { get; set; }
        //represents the name of a test
        public string testName { get; set; }
        //represents the result of a test
        public int result { get; set; }
        //represents the minimul value of the test's normal range
        public string minReferenceRange { get; set; }
        //represents the maximum value of the test's normal range
        public string maxReferenceRange { get; set; }
        //represents the units associated with a test's value
        public string units { get; set; }



        public TestClass()
        {
                this.testId = System.Threading.Interlocked.Increment(ref _IdIncrementer);          
        }

        }
}

