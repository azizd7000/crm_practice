namespace Crm;
public readonly struct OrderInfo
{
    public readonly string Id { get; init; }
    public readonly string Desc { get; init; }
    public readonly string Price { get; init; }
    public readonly string Date { get; init; }
    public readonly string Type { get; init; }
    public readonly string Address { get; init; }
}