using Crm.Entities;
using Crm;
namespace Crm.Services;
public sealed class ClientService
{
   private List<Client> clientsList = new List<Client>();
   public Client CreateClient(
        string firstName,
        string lastName,
        string middleName,
        short  age,
        string passportNumber,
        string gender,
        string phone,
        string email,
        string password

   ) 
   {
   var client =  new Client
   {
      FirstName = firstName,
      LastName = lastName,
      MiddleName = middleName,
      Age = age,
      PassportNumber = passportNumber,
      Gender = gender,
      Phone = phone,
      Email = email,
      Password = password
   }   ;
   clientsList.Add(client);
   
   }

   
}

