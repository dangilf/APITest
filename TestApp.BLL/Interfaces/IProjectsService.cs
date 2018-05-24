using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestApp.Domain.Core.Models;

namespace TestApp.BLL.Interfaces
{
    public interface IProjectsService
    {
        IEnumerable<Task> GetAllTasks(int projectId);
        IEnumerable<Task> GetTasksByStatus(int projectId, string status);
        IEnumerable<Project> GetAll();
        IEnumerable<Project> Get(Func<Project, bool> predicate);
        Project GetById(int id);
        void Create(Project entity);
        void Delete(Project entity);
        void Delete(int id);
        void Update(Project entity);
    }
}
