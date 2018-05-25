
using System.Web.Mvc;
using TestApp.BLL.Services;

namespace TestApp.API.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
