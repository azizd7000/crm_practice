using Crm.Entities;
using Crm;
namespace Crm.Services;
public sealed class OrderService
{
   private List<Order> ordersList = new List<Order>();

    public Order CreateOrder(
        string id,
        string desc,
        string price,
        string date,
        string type,
        string address
    )
    {
     var order = new Order
     {
        Id = id,
        Desc = desc,
        Price = price,
        Date = date,
        Type = type,
        Address = address
     }   ;
   ordersList.Add(order);

    }
    
}