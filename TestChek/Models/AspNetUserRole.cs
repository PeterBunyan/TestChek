namespace TestChek.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AspNetUserRole
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DBCounter { get; set; }

        //[Key]
        [Required]
        [StringLength(128)]
        public string UserId { get; set; }

        //[Key]
        [Required]
        [StringLength(128)]
        public string RoleId { get; set; }

        public AspNetUserRole()
        {

        }


        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        //public AspNetUserRole()
        //{
        //    AspNetUsers = new HashSet<AspNetUser>();
        //}
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //public int DBCounter { get; set; }

        ////[Key]
        //[Required]
        //[StringLength(128)]
        //public string UserId { get; set; }

        ////[Key]
        //[Required]
        //[StringLength(128)]
        //public string RoleId { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<AspNetUser> AspNetUsers { get; set; }


    }
}