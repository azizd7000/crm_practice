using Crm.Entities;
using Crm;
namespace Crm.Services;
public sealed class OrderService
{
    public Order CreateOrder(
        string id,
        string desc,
        string price,
        string date,
        string type,
        string address
    )
    {
     return new()
     {
        Id = id,
        Desc = desc,
        Price = price,
        Date = date,
        Type = type,
        Address = address
     }   ;
    }
}