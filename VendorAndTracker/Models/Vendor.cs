using System.Collections.Generic;

namespace VendorAndTracker.Models
{
  public class Vendor
  {
    public string VendorName { get; set; }
    public string VendorAddress { get; set; }
    public string VendorContact { get; set; }
    public int Id{ get; }
    private static List<Vendor> _instances = new List<Vendor> {};

    public Vendor(string vendorName, string vendorAddress, string vendorContact)
    {
      VendorName = vendorName;
      VendorAddress = vendorAddress;
      VendorContact = vendorContact;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Vendor> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}