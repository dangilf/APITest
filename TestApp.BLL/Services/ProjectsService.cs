using System;
using System.Collections.Generic;
using TestApp.BLL.Interfaces;
using TestApp.DAL.Interfaces;
using TestApp.Domain.Core.Models;

namespace TestApp.BLL.Services
{
    public class ProjectsService : BaseCRUDService<Project>, IProjectsService
    {
        public ProjectsService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public IEnumerable<Task> GetAllTasks(int projectId)
        {
            return uof.Repository<Task>().Get(t => t.Project.ID == projectId);
        }

        public IEnumerable<Task> GetTasksByStatus(int projectId, string status)
        {
            return uof.Repository<Task>().Get(t => t.Project.ID == projectId && t.Status.Equals(status));
        }
    }
}
