using System.Web.Mvc;
using CustomPage.Filters;

namespace CustomPage.Controllers
{
    [Localization("en")]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}