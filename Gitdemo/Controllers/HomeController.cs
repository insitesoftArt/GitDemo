using System.Web.Mvc;

namespace Gitdemo.Controllers
{
    public class HomeController : Controller
    {
        //patch 22222 dgdfgdfgdfg
        public ActionResult Index()
        {
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