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
        [Key]
        public int testId { get; set; }
        //represents the name of a test
        public string testName { get; set; }
        //represents the result of a test
        public float result { get; set; }
        //represents the minimul value of the test's normal range
        public float minReferenceRange { get; set; }
        //represents the maximum value of the test's normal range
        public float maxReferenceRange { get; set; }
        //represents the units associated with a test's value
        public string units { get; set; }



        public TestClass()
        {

                this.testId = System.Threading.Interlocked.Increment(ref _IdIncrementer);
            

            //Random testResult = new Random();

            //testName = "WBC";
            //minReferenceRange = 5.0f;
            //maxReferenceRange = 10.0f;
            //result = testResult.Next(5, 10);
            //units = "x 10^3/uL";

            //testName = "RBC";
            //minReferenceRange = 3.90f;
            //maxReferenceRange = 5.10f;
            //result = testResult.Next(3, 5);
            //units = "x 10^6/uL";
        }

        }
}

