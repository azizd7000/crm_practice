using Crm.Entities;
using Crm;
namespace Crm.Services;
public interface IOrderService 
    {
        Order CreateOrder(
        string id,
        string desc,
        string price,
        string date,
        string type,
        string address
        );

    }  

//Абстрактный класс
public abstract class OrderServiceAbstract 
    {
        public List<Order> ordersList = new List<Order>();
        public abstract  Order CreateOrder(
            string id,
            string desc,
            string price,
            string date,
            string type,
            string address
        );

      
    }
///клас наследник    
public class OrderService : OrderServiceAbstract, IOrderService
    {
       public override Order CreateOrder(
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
   Console.WriteLine( "Id: "+order.Id+" Desc: "+order.Desc+" Price: "+order.Price+" Date: "+order.Date+" Type: "+order.Type+" Address: "+order.Address);

   return ordersList.FirstOrDefault(order=>order.Desc == desc && order.Id == id);

    }
    }