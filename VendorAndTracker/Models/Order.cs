using System.Collections.Generic;

namespace VendorAndTracker.Models
{
  public class Order
  {
    public string OrderName { get; set; }
    public string OrderDescription { get; set; }
    public int Id{ get; }
    private static List<Order> _instances = new List<Order> {};

    public Order(string orderName, string orderDescription)
    {
      OrderName = orderName;
      OrderDescription = orderDescription;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Order Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}