namespace Crm.Entities;

public sealed class Client
{
    private string _firstName;
    private string _lastName;
    private string _middleName;
    private short _age;
    private string _passportNumber;
    private string _gender;

    public required string FirstName { 
                                      get => _firstName ?? string.Empty;
                                      init => _firstName = value is { Length: > 0 } ? value : throw new ArgumentOutOfRangeException(nameof(value), "Поле не может быть пустым") ; 
                                     }
                            
    public required string LastName  { 
                                      get => _lastName ?? string.Empty;
                                      init => _lastName = value is { Length: > 0 } ? value : throw new ArgumentOutOfRangeException(nameof(value), "Поле не может быть пустым") ; 
                                     }
    public required string MiddleName { 
                                       get => _lastName ?? string.Empty;
                                       init => _lastName = value is { Length: > 0 } ? value : throw new ArgumentOutOfRangeException(nameof(value), "Поле не может быть пустым") ; 
                                     }
  
    public short Age {
        //get; set;
        get => _age;
        init => _age = value > 0 ? value : throw new ArgumentOutOfRangeException(nameof(value),"Возраст не может быть минусовым");

    }
    public required string PassportNumber { 
                                           get => _passportNumber ?? string.Empty;
                                           init => _passportNumber = value is { Length: >  0 } ? value : throw new ArgumentOutOfRangeException(nameof(value), "Поле не может быть пустым") ; 
                                          }
    public required string Gender {  
                                   get => _gender ?? string.Empty;
                                   init => _gender = value is { Length: > 0 } ? value : throw new ArgumentOutOfRangeException(nameof(value), "Поле не может быть пустым") ; 
                                  }

   
}
