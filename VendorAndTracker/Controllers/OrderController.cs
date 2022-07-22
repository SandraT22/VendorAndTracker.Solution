using Microsoft.AspNetCore.Mvc;
using VendorAndTracker.Models;
using System.Collections.Generic;

namespace VendorAndTracker.Controllers
{
  public class OrderssController : Controller
  {
    [HttpGet("/vendors/{vendorId}/orders/new")]
    public ActionResult New(int vendorId)
    {
      Vendor newVendor = Vendor.Find(vendorId);
      return View(Vendor);
    }

     [HttpGet("/vendors/{vendorId}/orders/{orderId}")]
    public ActionResult Show(int vendorId, int orderId)
    {
      Order newOrder = Order.Find(orderId);
      Vendor newVendor = Vendor.Find(vendorId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("order", newOrder);
      model.Add("vendor", newVendor);
      return View(model);
    }
  }
}