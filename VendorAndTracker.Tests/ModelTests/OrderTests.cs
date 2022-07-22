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
      Order newOrder = new Order("test", "description", 0, "date");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void OrderConstructor_GetOrderName_String()
    {
      string orderName = "Test Order";
      string orderDescription = "100 Pastries";
      int orderPrice = 12;
      string orderDate = "6/22/22";
      Order newOrder = new Order(orderName, orderDescription, orderPrice, orderDate);
      string result = newOrder.OrderName;
      Assert.AreEqual(orderName, result);
    }

    [TestMethod]
    public void SetOrderName_SetOrderName_String()
    {
      string orderName = "Test Order";
      string orderDescription = "100 Pastries";
      int orderPrice = 12;
      string orderDate = "6/22/22";
      Order newOrder = new Order(orderName, orderDescription,orderPrice, orderDate);

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
      int orderPrice = 12;
      string orderDate = "6/22/22";
      Order newOrder = new Order(orderName, orderDescription, orderPrice, orderDate);
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
      string description1 = "Test";
      int orderPrice1 = 12;
      string orderDate1 = "6/22/22";
      string name02 = "First Order";
      string description2 = "100";
      int orderPrice2 = 11;
      string orderDate2 = "6/20/22";
      Order newOrder1 = new Order(name01, description1, orderPrice1, orderDate1);
      Order newOrder2 = new Order(name02, description2, orderPrice2, orderDate2);
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };

      List<Order> result = Order.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_ReturnOrderId_Int()
    {
      string name01 = "Test Name";
      string description1 = "Test";
      int orderPrice = 12;
      string orderDate = "6/22/22";
      Order newOrder = new Order(name01, description1, orderPrice1, orderDate1);

      int result = newOrder.Id;

      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectOrders_Order()
    {
      string name01 = "Test Name";
      string description1 = "Test";
      int orderPrice1 = 12;
      string orderDate1 = "6/22/22";
      string name02 = "First Order";
      string description2 = "100";
      int orderPrice2 = 11;
      string orderDate2 = "6/20/22";
      Order newOrder1 = new Order(name01, description1, orderPrice1, orderDate1);
      Order newOrder2 = new Order(name02, description2, orderPrice2, orderDate2);

      Order result = Order.Find(2);

      Assert.AreEqual(newOrder2, result);
    }

  }
}