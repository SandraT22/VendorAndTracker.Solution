using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorAndTracker.Models;
using System;

namespace VendorAndTracker.Tests
{
  [TestClass]
  public class OrderTests //: IDisposable
  {

    // public void Dispose()
    // {
    //   Item.ClearAll();
    // }

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
      //Arrange
      string orderName = "Test Order";
      Order newOrder = new Order(orderName);

      //Act
      string updatedName = "First Order";
      newOrder.OrderName = updatedName;
      string result = newOrder.OrderName;

      //Assert
      Assert.AreEqual(orderName, result);
    }
  }
}