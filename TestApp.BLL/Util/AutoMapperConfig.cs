using AutoMapper;
using TestApp.BLL.Models;
using TestApp.DAL.Models;

namespace TestApp.BLL.Util
{
    public class AutoMapperConfig
    {
        public static void Initialize()
        {
            Mapper.Initialize((config) =>
            {
                config.CreateMap<Employee, EmployeeDTO>().ReverseMap();
                config.CreateMap<Project, ProjectDTO>().ReverseMap();
                config.CreateMap<Task, TaskDTO>().ReverseMap();
            });
        }
    }
}