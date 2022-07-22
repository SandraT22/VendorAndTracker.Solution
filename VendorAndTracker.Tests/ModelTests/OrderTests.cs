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
  }
}