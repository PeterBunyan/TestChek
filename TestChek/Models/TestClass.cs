using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestChek.Models
{
    public class TestClass
    {
        //represents the name of a test
        public string TestName;
        //represents the result of a test
        public float Result;
        //represents the minimul value of the test's normal range
        public float MinReferenceRange;
        //represents the maximum value of the test's normal range
        public float MaxReferenceRange;
        //represents the units associated with a test's value
        public string Units;


        public TestClass()
        {
            Random testResult = new Random();

            TestName = "WBC";
            MinReferenceRange = 5.0f;
            MaxReferenceRange = 10.0f;
            Result = testResult.Next(5, 10);
            Units = "x 10^3/uL";

            TestName = "RBC";
            MinReferenceRange = 3.90f;
            MaxReferenceRange = 5.10f;
            Result = testResult.Next(3, 5);
            Units = "x 10^6/uL";
    }

        }
}

