using AutoMapper;
using System;
using System.Collections.Generic;
using TestApp.BLL.Services;
using TestApp.BLL.Models;
using TestApp.DAL.Interfaces;
using TestApp.DAL.Models;

namespace TestApp.BLL.Services
{
    public class ProjectsService : BaseCRUDService<Project, ProjectDTO>, IProjectsService
    {
        public ProjectsService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public IEnumerable<TaskDTO> GetAllTasks(int projectId)
        {
            var entities = uof.Repository<Task>().Get(t => t.Project!=null && t.Project.ID == projectId);
            var entitiesDTO = Mapper.Map<IEnumerable<TaskDTO>>(entities);

            return entitiesDTO;
        }

        public IEnumerable<TaskDTO> GetTasksByStatus(int projectId, string status)
        {
            var entities = uof.Repository<Task>().Get(t => t.Project!=null &&  t.Project.ID == projectId && t.Status.Equals(status, StringComparison.InvariantCultureIgnoreCase));
            var entitiesDTO = Mapper.Map<IEnumerable<TaskDTO>>(entities);
            return entitiesDTO;
        }
    }
}
