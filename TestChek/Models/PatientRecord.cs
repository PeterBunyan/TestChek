using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TestChek.Models
{
    public partial class PatientRecord: TestClass
    {
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
    }
}