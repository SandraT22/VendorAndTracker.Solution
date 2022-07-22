using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorAndTracker.Models;
using System;

namespace VendorAndTracker.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {

    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfRecord_Record()
    {
      Order newOrder = new Order("test");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void OrderConstructor_GetOrderName_String()
    {
      string orderName = "Test Order";
      Order newOrder = new Order(orderName);
      string result = newOrder.OrderName;
      Assert.AreEqual(orderName, result);
    }

    [TestMethod]
    public void SetOrderName_SetOrderName_String()
    {
      string orderName = "Test Order";
      Order newOrder = new Order(orderName);

      string updatedName = "First Order";
      newOrder.OrderName = updatedName;
      string result = newOrder.OrderName;

      Assert.AreEqual(updatedName, result);
    }

    [TestMethod]
    public void OrderConstructor_GetOrderDescription_String()
    {
      string orderName = "Test Order";
      string orderDescription = "100 Pastries";
      Order newOrder = new Order(orderName, orderDescription);
      string result = newOrder.OrderDescription;
      Assert.AreEqual(orderDescription, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      List<Order> newList = new List<Order> { };

      List<Order> result = Order.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }

     [TestMethod]
    public void GetAll_ReturnsOrders_OrderList()
    {
      string name01 = "Test Name";
      string name02 = "First Order";
      Order newOrder1 = new Order(name01);
      Order newOrder2 = new Order(name02);
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };

      List<Order> result = Order.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }

  }
}