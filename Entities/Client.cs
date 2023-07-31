namespace Crm.Entities;
public sealed class Client
{
    public required string FirstName { 
                                get  => FirstName;
                                set  {
                                     if (!string.IsNullOrEmpty(value)){
                                      FirstName = value;
                                     }
                                     else {
                                       throw new ArgumentOutOfRangeException(nameof(FirstName), "Поле не может быть пустым") ; 
                                     } 
                                     }
                                     }
                            
    public required string LastName  { 
                                get  => LastName;
                                set  {
                                     if (!string.IsNullOrEmpty(value)){
                                      LastName = value;
                                     }
                                     else {
                                       throw new ArgumentOutOfRangeException(nameof(LastName), "Поле не может быть пустым") ; 
                                     } 
                                     }
                                     }
    public required string MiddleName { 
                                get  => MiddleName;
                                set  {
                                     if (!string.IsNullOrEmpty(value)){
                                      MiddleName = value;
                                     }
                                     else {
                                       throw new ArgumentOutOfRangeException(nameof(MiddleName), "Поле не может быть пустым") ; 
                                     } 
                                     }
                                     }
    // public required short Age { 
    //                             get  => Age;
    //                             set  {
    //                                  if (!string.IsNullOrEmpty(value)){
    //                                   (Age) = value;
    //                                  }
    //                                  else {
    //                                    throw new ArgumentOutOfRangeException(nameof(Age), "Поле не может быть пустым") ; 
    //                                  } 
    //                                  }
    //                                  }
    public short Age {get;set;}
    public required string PassportNumber { 
                                get  => PassportNumber;
                                set  {
                                     if (!string.IsNullOrEmpty(value)){
                                      PassportNumber = value;
                                     }
                                     else {
                                       throw new ArgumentOutOfRangeException(nameof(PassportNumber), "Поле не может быть пустым") ; 
                                     } 
                                     }
                                     }
    public required string Gender  { 
                                get  => Gender;
                                set  {
                                     if (!string.IsNullOrEmpty(value)){
                                      Gender = value;
                                     }
                                     else {
                                       throw new ArgumentOutOfRangeException(nameof(Gender), "Поле не может быть пустым") ; 
                                     } 
                                     }
                                     }

   
}