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
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PatientRecordNumber { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string medRecNumber { get; set; }
        public string orderingProvider { get; set; }
        public string timeofTest { get; set; }

        [NotMapped]
        public List<List<TestClass>> myTestResults { get; set; }

        public PatientRecord()
        {
        }
    }
}