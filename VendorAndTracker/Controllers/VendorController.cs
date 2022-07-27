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
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }

    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }

     [HttpGet("/vendors/{vendorId}")]
    public ActionResult Show(int vendorId)
    {
      Vendor foundVendor = Vendor.Find(vendorId);
      return View(foundVendor);
    }

    [HttpPost("/vendors")]
    public ActionResult Create(string vendorName, string vendorAddress, string vendorContact)
    {
      Vendor newVendor = new Vendor(vendorName, vendorAddress, vendorContact);
      return RedirectToAction("Index");
    }

    [HttpPost("/vendors/{vendorId}/orders")]
    public ActionResult Create(int vendorId, string orderName, string orderDescription, int orderPrice, string orderDate)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor foundVendor = Vendor.Find(vendorId);
      Order newOrder = new Order(orderName, orderDescription, orderPrice, orderDate);
      foundVendor.AddOrder(newOrder); 
      // List<Order> vendorOrders = foundVendor.Orders; //error here
      // model.Add("orders", vendorOrders);
      model.Add("vendor", foundVendor);
      return View("Show", model);
    }
  }
}