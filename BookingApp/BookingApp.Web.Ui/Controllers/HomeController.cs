using System.Web.Mvc;
using BookingApp.Web.Ui.Models;

namespace BookingApp.Web.Ui.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            var vm = new BookViewModel();
            return View(vm);
        }
    }
}