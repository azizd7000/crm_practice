using Crm.Entities;
using Crm;
namespace Crm.Services;
public sealed class ClientService
{
   public Client CreateClient(
        string firstName,
        string lastName,
        string middleName,
        short  age,
        string passportNumber,
        string gender

   ) 
   {
   return new()
   {
      FirstName = firstName,
      LastName = lastName,
      MiddleName = middleName,
      Age = age,
      PassportNumber = passportNumber,
      Gender = gender
   }   ;
   } 
   
}
