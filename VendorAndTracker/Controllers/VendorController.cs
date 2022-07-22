using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using VendorAndTracker.Models;

namespace VendorAndTracker.Controllers
{
  public class VendorsController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendors> allVendors = Vendor.GetAll();
      return View(allVendors);
    }
  }
}