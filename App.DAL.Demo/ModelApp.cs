namespace App.DAL.Context
{
    using App.Entities;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ModelApp : DbContext
    {
 
        public ModelApp() : base(GetConnectionString())
        {
            // @"data source=(LocalDb)\MSSQLLocalDB;initial catalog=TrainingIS;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework"
        }

        public static string GetConnectionString()
        {

            string ConnectionString =  @"data source=(LocalDb)\MSSQLLocalDB;initial catalog=Trainee_Management_Demo;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";

            return ConnectionString;
        }

        public virtual DbSet<Trainee> Trainees { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}