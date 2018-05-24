using System;
using System.Collections.Generic;
using System.Data.Entity;
using TestApp.Domain.Core.Models;

namespace TestApp.DAL.EF
{
    public class StoreDbInitializer : CreateDatabaseIfNotExists<TestAppDBContext>
    {
        protected override void Seed(TestAppDBContext db)
        {
            db.Employees.Add(new Employee()
            {
                BirthDate = DateTime.Now.AddYears(-25),
                EmploymentDate = DateTime.Now.AddMonths(-10),
                Gender = "Male",
                Name = "John Snow"
            });
            db.Employees.Add(new Employee()
            {
                BirthDate = DateTime.Now.AddYears(-22).AddMonths(3),
                EmploymentDate = DateTime.Now.AddMonths(-8),
                Gender = "Female",
                Name = "Aria Stark"
            });

            db.Projects.Add(new Project()
            {
                Key="sdlfkjQwq4124f",
                Title="Migration"
            });
            db.Projects.Add(new Project()
            {
                Key = "asfgret235tfwe",
                Title = "Transition"
            });

            db.Tasks.Add(new Task()
            {
                Description="Deploy application",
                Title="App1Deployment",
                Status="Open"
            });

            db.Tasks.Add(new Task()
            {
                Description = "Deploy application",
                Title = "App1Deployment",
                Status = "Open"
            });

            db.Tasks.Add(new Task()
            {
                Description = "Remove application",
                Title = "App2Retirement",
                Status = "Done"
            });

            db.SaveChanges();
        }
    }
}
