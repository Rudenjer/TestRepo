using System.Web.Mvc;

namespace TestProject.WebUI.Controllers
{
    public class OwnerController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
    }
}