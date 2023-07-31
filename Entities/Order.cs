namespace Crm.Entities;
public sealed class Order
{
    public string OrderId { get; set; }
    public string OrderDesc { get; set; }
    public string OrderPrice { get; set; }
    public string OrderDate { get; set; }
    public string OrderType { get; set; }
    public string OrderAddress { get; set; }
}