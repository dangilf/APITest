
using System.Web.Mvc;
using TestApp.BLL.Interfaces;

namespace TestApp.API.Controllers
{
    public class HomeController : Controller
    {
        IEmployeesService employeesService;

        public HomeController(IEmployeesService empService)
        {
            employeesService = empService;
        }

        public ActionResult Index()
        {


            var employees = employeesService.GetAll();

            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
