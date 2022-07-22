using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorAndTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorAndTracker.Tests
{
  [TestClass]
  public class VendorTests //: //IDisposable
  {

  // public void Dispose()
  // {
  //   Category.ClearAll();
  // }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test name", "test address", "test contact");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void VendorConstructor_GetVendorName_String()
    {
      string name = "Test Vendor";
      string address = "test address";
      string contact = "Test contact";
      Vendor newVendor = new Vendor(name, address, contact);
      string result = newVendor.VendorName;
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void SetVendorName_SetVendorName_String()
    {
      string name = "Test Vendor";
      string address = "test address";
      string contact = "Test contact";
      Vendor newVendor = new Vendor(name, address, contact);

      string updatedName = "First Vendor";
      newVendor.VendorName = updatedName;
      string result = newVendor.VendorName;

      Assert.AreEqual(updatedName, result);
    }

    [TestMethod]
    public void SetVendorAddress_SetVendorAddress_String()
    {
      string name = "Test Vendor";
      string address = "test address";
      string contact = "Test contact";
      Vendor newVendor = new Vendor(name, address, contact);

      string updatedAddress = "First Address";
      newVendor.VendorAddress = updatedAddress;
      string result = newVendor.VendorAddress;

      Assert.AreEqual(updatedAddress, result);
    }
  }
}