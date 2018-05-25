namespace TestApp.DAL.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<TestApp.DAL.EF.TestAppDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TestApp.DAL.EF.TestAppDBContext context)
        {
            context.Employees.AddOrUpdate(new Employee()
            {
                BirthDate = DateTime.Now.AddYears(-25),
                EmploymentDate = DateTime.Now.AddMonths(-10),
                Gender = "Male",
                Name = "John Snow"
            });
            context.Employees.AddOrUpdate(new Employee()
            {
                BirthDate = DateTime.Now.AddYears(-22).AddMonths(3),
                EmploymentDate = DateTime.Now.AddMonths(-8),
                Gender = "Female",
                Name = "Aria Stark"
            });

            context.Projects.AddOrUpdate(new Project()
            {
                Key = "sdlfkjQwq4124f",
                Title = "Migration"
            });
            context.Projects.AddOrUpdate(new Project()
            {
                Key = "asfgret235tfwe",
                Title = "Transition"
            });

            context.Tasks.AddOrUpdate(new Task()
            {
                Description = "Deploy application",
                Title = "App1Deployment",
                Status = "Open"
            });

            context.Tasks.AddOrUpdate(new Task()
            {
                Description = "Remove application",
                Title = "App2Retirement",
                Status = "Done"
            });

            context.SaveChanges();
        }
    }
}
