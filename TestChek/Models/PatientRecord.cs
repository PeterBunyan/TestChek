using System;
using System.Collections.Generic;
<<<<<<< HEAD
=======
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
>>>>>>> API
using System.Linq;
using System.Web;

namespace TestChek.Models
{
    public partial class PatientRecord: TestClass
    {
<<<<<<< HEAD
        public string Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string orderingProvider { get; set; }
        public string medRecNumber { get; set; }
        public DateTime timeofTest { get; set; }
        public List<TestClass> myTestResults { get; set; }
=======
        //Primary Key in PatientRecords DB table
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PatientRecordNumber { get; set; }
        //Stores first name of patient
        public string firstName { get; set; }
        //Stores last name of patient
        public string lastName { get; set; }
        //Stores medical record number of patient - same as AspNetUser Id created upon registration for site access
        public string medRecNumber { get; set; }
        //Stores name of provider that ordered tests for the patient
        public string orderingProvider { get; set; }
        //time testing was completed
        public string timeofTest { get; set; }

        //Stores list of tests ordered for patient. Used to build a patient record for each test in list.
        [NotMapped]
        public List<List<TestClass>> myTestResults { get; set; }

        public PatientRecord()
        {
        }
>>>>>>> API
    }
}