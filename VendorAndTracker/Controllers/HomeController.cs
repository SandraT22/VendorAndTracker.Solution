using Microsoft.AspNetCore.Mvc;

namespace VendorAndTracker.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

    }
}