﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestChek.Models
{

    public class TestPanel
    {
        //primary key, though not currently implemented in DB
        [Key]
        public int _testPanelId { get; set; }

        private List<TestClass> _panelTestList; /*{ get; set; }*/
        //testResult used to generate random results to simulate different test result values
        private Random _resultRandom = new Random(Guid.NewGuid().GetHashCode());
        //returns result from backing variable
        public Random testResult { get { return _resultRandom; } }
        //test panel name
        public string panelName { get; set; }
        //returns a list of tests
        public List<TestClass> panelTestList { get { return _panelTestList; } }

        //useage: takes string as input and assigns matching test panel to a list
        public void testSelector(string testName)
        {
            {
                if (testName == "CBC")
                {
                    _panelTestList = CBC();
                    _testPanelId = 1;
                }
                else if (testName == "BMP")
                {
                    _panelTestList = BasicMetPanel();
                    _testPanelId = 2;
                }
                else if (testName == "UA")
                {
                    _panelTestList = UrineScreen();
                    _testPanelId = 3;
                }
                else
                    throw new Exception("Test Panel spelled incorrectly or does not exist. Try 'CBC', 'BMP', or 'UA'.");
                //return View(viewModel);
            }
        }

        //list representing a test panel
        private List<TestClass> CBC()
        {
            return new List<TestClass>
                {
                new TestClass { testName = "WBC", result = (testResult.Next(200, 1800) / 100), minReferenceRange = "5.0", maxReferenceRange = "10.0", units = "x 10^3/uL"},
                new TestClass { testName = "RBC", result = (testResult.Next(300, 550) / 100), minReferenceRange = "3.90", maxReferenceRange = "5.10", units = "x 10^6/uL" },
                new TestClass { testName = "HGB", result = (testResult.Next(750, 1650) / 100), minReferenceRange = "11.5", maxReferenceRange = "15.3", units = "g/dL"},
                new TestClass { testName = "HCT", result = (testResult.Next(2520, 4710) / 100), minReferenceRange = "35.2", maxReferenceRange = "45.1", units = "%" },
                new TestClass { testName = "PLT", result = (testResult.Next(900, 6010) / 10), minReferenceRange = "160.0", maxReferenceRange = "401.0", units = "x 10^3/uL" }
                };
        }
        //list representing a test panel
        private List<TestClass> BasicMetPanel()
        {
            return new List<TestClass>
                {
                new TestClass { testName = "Sodium", result = (testResult.Next(12000, 15500) / 100), minReferenceRange = "135.0", maxReferenceRange = "146.0", units = "MMOL/L"},
                new TestClass { testName = "Potassium", result = (testResult.Next(300, 550) / 100), minReferenceRange = "3.60", maxReferenceRange = "5.20", units = "MMOL/L" },
                new TestClass { testName = "Chloride", result = (testResult.Next(9800, 11500) / 100), minReferenceRange = "100.0", maxReferenceRange = "108.0", units = "MMOL/L"},
                new TestClass { testName = "Carbon Dioxide", result = (testResult.Next(1500, 2500) / 100), minReferenceRange = "21.0", maxReferenceRange = "32.0", units = "MMOL/L" },
                new TestClass { testName = "Glucose", result = (testResult.Next(6500, 25000) / 100), minReferenceRange = "70.0", maxReferenceRange = "99.0", units = "MG/DL" },
                new TestClass { testName = "BUN", result = (testResult.Next(400, 2500) / 100), minReferenceRange = "6.0", maxReferenceRange = "22.0", units = "MG/DL"},
                new TestClass { testName = "Creatinine", result = (testResult.Next(40, 150) / 100), minReferenceRange = "0.5", maxReferenceRange = "1.3", units = "MG/DL" },
                new TestClass { testName = "Calcium", result = (testResult.Next(800, 1100) / 100), minReferenceRange = "8.5", maxReferenceRange = "10.1", units = "MG/DL" }
                };
        }
        //list representing a test panel
        private List<TestClass> UrineScreen()
        {
            return new List<TestClass>
                {
                new TestClass { testName = "Glucose", result = (testResult.Next(0, 100) / 100), minReferenceRange = "0.0", maxReferenceRange = "1.0", units = "MG/DL"},
                new TestClass { testName = "Biliruben", result = (testResult.Next(0, 100) / 100), minReferenceRange = "0.0", maxReferenceRange = "1.0", units = "N/A" },
                new TestClass { testName = "Ketones", result = (testResult.Next(0, 100) / 100), minReferenceRange = "0.0", maxReferenceRange = "1.0", units = "MG/DL"},
                new TestClass { testName = "Spec. Gravity", result = (testResult.Next(100, 104) / 100), minReferenceRange = "1.003", maxReferenceRange = "1.035", units = "N/A" },
                new TestClass { testName = "Blood", result = (testResult.Next(0, 300) / 100), minReferenceRange = "0.0", maxReferenceRange = "3.0", units = "N/A" },
                new TestClass { testName = "pH", result = (testResult.Next(400, 800) / 100), minReferenceRange = "5.0", maxReferenceRange = "9.0", units = "N/A"},
                new TestClass { testName = "Protein", result = (testResult.Next(0, 30000) / 100), minReferenceRange = "0.0", maxReferenceRange = "300.0", units = "MG/DL" },
                new TestClass { testName = "Urobilinogen", result = (testResult.Next(800, 1100) / 100), minReferenceRange = "0.0", maxReferenceRange = "1.0", units = "EU/DL" },
                new TestClass { testName = "Nitrite", result = (testResult.Next(0, 100) / 100), minReferenceRange = "0.0", maxReferenceRange = "1.0", units = "N/A" },
                new TestClass { testName = "Leukocyte Esterase", result = (testResult.Next(0, 300) / 100), minReferenceRange = "0.0", maxReferenceRange = "3.0", units = "N/A" }
            };
        }
        public TestPanel()
        {

        }
    }

}