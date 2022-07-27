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
    public static List<Order> Orders { get; set; }

    public Vendor(string vendorName, string vendorAddress, string vendorContact)
    {
      VendorName = vendorName;
      VendorAddress = vendorAddress;
      VendorContact = vendorContact;
      Orders = new List<Order> {};
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

    public static Vendor Find(int searchId)
    {
      return _instances[searchId-1];
    }
    public void AddOrder(Order newOrder)
        {
            Orders.Add (newOrder);
        }
  }
}