using System;
using System.Collections.Generic;
using System.Data.Entity;
using TestApp.Domain.Core.Models;

namespace TestApp.DAL.EF
{
    public class TestAppDBContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Task> Tasks { get; set; }       

        public TestAppDBContext() : base("DBConnection")
        {
            //Database.SetInitializer<TestAppDBContext>(new StoreDbInitializer());
        }
    }
}
