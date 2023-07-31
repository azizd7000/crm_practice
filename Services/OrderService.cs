using Crm.Entities;
using Crm;
namespace Crm.Services;
public sealed class OrderService
{
    public Order CreateOrder(OrderInfo orderInfo) 
   {
   return new()
   {
    OrderId = orderInfo.Id,
    OrderDesc = orderInfo.Desc,
    OrderPrice = orderInfo.Price,
    OrderDate = orderInfo.Date,
    OrderType = orderInfo.Type,
    OrderAddress = orderInfo.Address
   }   ;
   } 
}
