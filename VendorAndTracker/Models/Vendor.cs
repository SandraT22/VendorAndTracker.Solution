using System.Collections.Generic;

namespace VendorAndTracker.Models
{
  public class Vendor
  {
    public string VendorName { get; set; }
    public string VendorAddress { get; set; }
    public string VendorContact { get; set; }

    public Vendor(string vendorName, string vendorAddress, string vendorContact)
    {
      VendorName = vendorName;
      VendorAddress = vendorAddress;
      VendorContact = vendorContact;
    }
  }
}