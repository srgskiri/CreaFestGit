using System.Web.Mvc;

namespace MyWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.WelcomeMsg = MyLibrary4Web.MyExoticLibrary4Web.GetWelcomeMessage();
            ViewBag.Now = MyLibrary4Web.MyExoticLibrary4Web.GetNow();

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}