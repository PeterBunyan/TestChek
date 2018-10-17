namespace TestChek.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ModelDBContext : DbContext
    {
        // Your context has been configured to use a 'ModelDBContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'TestChek.Models.ModelDBContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'ModelDBContext' 
        // connection string in the application configuration file.

        //public partial class ModelDBContext : DbContext
        
            public ModelDBContext()
                : base("name=ModelDBContext")
            {
            }

<<<<<<< HEAD
            public virtual DbSet<TestClass> TestClasses { get; set; }
            public virtual DbSet<PatientRecord> PatientRecords { get; set; }
            public virtual DbSet<OrderedTest> OrderedTests { get; set; }
            public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
=======
            public virtual DbSet<PatientRecord> PatientRecords { get; set; }
            public virtual DbSet<OrderedTest> OrderedTests { get; set; }
            public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
            public virtual DbSet<AspNetUserRole> AspNetUserRoles { get; set; }
>>>>>>> API
            public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
            public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
            public virtual DbSet<AspNetUser> AspNetUsers { get; set; }

<<<<<<< HEAD
            //simplified from: public System.Data.Entity.DbSet<TestChek.Models.OrderedTestViewModel> OrderedTestViewModels { get; set; }
            //public virtual DbSet<OrderedTestViewModel> OrderedTestViewModels { get; set; }
            //public System.Data.Entity.DbSet<TestChek.ViewModel.OrderedTestViewModel> OrderedTestViewModels { get; set; }

=======
>>>>>>> API



        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}