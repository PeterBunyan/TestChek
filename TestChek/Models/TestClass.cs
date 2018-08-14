using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestChek.Models
{
    public class TestClass
    {
        //represents the name of a test
        public string testName;
        //represents the result of a test
        public float result;
        //represents the minimul value of the test's normal range
        public float minReferenceRange;
        //represents the maximum value of the test's normal range
        public float maxReferenceRange;
        //represents the units associated with a test's value
        public string units;


        public TestClass()
        {
            Random testResult = new Random();

            testName = "WBC";
            minReferenceRange = 5.0f;
            maxReferenceRange = 10.0f;
            result = testResult.Next(5, 10);
            units = "x 10^3/uL";

            testName = "RBC";
            minReferenceRange = 3.90f;
            maxReferenceRange = 5.10f;
            result = testResult.Next(3, 5);
            units = "x 10^6/uL";
    }

        }
}

