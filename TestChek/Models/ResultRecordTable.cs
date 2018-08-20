namespace TestChek.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ResultRecordTable")]
    public partial class ResultRecordTable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdPrimaryKey { get; set; }

        [StringLength(128)]
        public string Id { get; set; }

        [StringLength(50)]
        public string TestName { get; set; }

        public double? Result { get; set; }

        public double? MinReferenceRange { get; set; }

        public double? MaxReferenceRange { get; set; }

        [StringLength(15)]
        public string Units { get; set; }
    }
}
