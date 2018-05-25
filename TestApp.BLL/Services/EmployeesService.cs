using AutoMapper;
using System.Collections.Generic;
using TestApp.BLL.Services;
using TestApp.BLL.Models;
using TestApp.DAL.Interfaces;
using TestApp.DAL.Models;
using System;

namespace TestApp.BLL.Services
{
    public class EmployeesService : BaseCRUDService<Employee, EmployeeDTO>, IEmployeesService
    {
        public EmployeesService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public IEnumerable<TaskDTO> GetAllTasks(int employeeId)
        {
            var entities= uof.Repository<Task>().Get(t => t.Employee != null
                                                 && t.Employee.ID == employeeId);
            var entitiesDTO = Mapper.Map<IEnumerable<TaskDTO>>(entities);


            return entitiesDTO;
        }

        public IEnumerable<TaskDTO> GetAllTasksByProject(int employeeId, int projectId)
        {
            var entities = uof.Repository<Task>().Get(t => t.Employee != null && t.Project != null
                                            && t.Employee.ID == employeeId && t.Project.ID == projectId);
            var entitiesDTO = Mapper.Map<IEnumerable<TaskDTO>>(entities);


            return entitiesDTO;
        }

        public IEnumerable<TaskDTO> GetAllTasksByStatus(int employeeId, string status)
        {
            var entities = uof.Repository<Task>().Get(t => t.Employee != null &&
                                                    t.Employee.ID == employeeId && t.Status.Equals(status, StringComparison.InvariantCultureIgnoreCase));
            var entitiesDTO = Mapper.Map<IEnumerable<TaskDTO>>(entities);

            return entitiesDTO;           
        }
    }
}
