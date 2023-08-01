namespace Crm.Entities;
public sealed class Order
{
    private string _Id;
    private string _Desc;
    private string _Price;
    private string _Date;
    private string _Type;
    private string _Address;

    public required string Id { 
                                      get => _Id ?? string.Empty;
                                      init => _Id = value is { Length: > 0 } ? value : throw new ArgumentOutOfRangeException(nameof(value), "Поле не может быть пустым") ; 
                                     }
    public string Desc {  
                                      get => _Desc ?? string.Empty;
                                      init => _Desc = value is { Length: > 0 } ? value : throw new ArgumentOutOfRangeException(nameof(value), "Поле не может быть пустым") ; 
                                     }
    public string Price {  
                                      get => _Price ?? string.Empty;
                                      init => _Price = value is { Length: > 0 } ? value : throw new ArgumentOutOfRangeException(nameof(value), "Поле не может быть пустым") ; 
                                     }
    public string Date { 
                                      get => _Date ?? string.Empty;
                                      init => _Date = value is { Length: > 0 } ? value : throw new ArgumentOutOfRangeException(nameof(value), "Поле не может быть пустым") ; 
                                      }
    public string Type {  
                                      get => _Type ?? string.Empty;
                                      init => _Type = value is { Length: > 0 } ? value : throw new ArgumentOutOfRangeException(nameof(value), "Поле не может быть пустым") ; 
                                     }
    public string Address {  
                                      get => _Address ?? string.Empty;
                                      init => _Address = value is { Length: > 0 } ? value : throw new ArgumentOutOfRangeException(nameof(value), "Поле не может быть пустым") ; 
                                      }
}