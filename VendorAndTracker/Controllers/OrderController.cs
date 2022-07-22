// using Microsoft.AspNetCore.Mvc;
// using VendorAndTracker.Models;
// using System.Collections.Generic;

// namespace VendorAndTracker.Controllers
// {
//   public class OrderssController : Controller
//   {
//     [HttpGet("/vendors/{vendorId}/orders/new")]
//     public ActionResult New(int vendorId)
//     {
//       Vendor newVendor = Vendor.Find(vendorId);
//       return View(Vendor);
//     }
//   }
// }