using Crm.Entities;
using Crm;
namespace Crm.Services;
///Интерфейс
public interface IClientService
    {
        Client CreateClient(
            string firstName,
            string lastName,
            string middleName,
            short age,
            string passportNumber,
            string gender,
            string phone,
            string email,
            string password
        );

    }  
//Абстрактный класс
public abstract class ClientServiceAbstract
    {
        public List<Client> clientsList = new List<Client>();

        public abstract Client CreateClient(
            string firstName,
            string lastName,
            string middleName,
            short age,
            string passportNumber,
            string gender,
            string phone,
            string email,
            string password
        );

      
    }
///клас наследник    
public class ClientService : ClientServiceAbstract, IClientService
    {
        public override Client CreateClient(
            string firstName,
            string lastName,
            string middleName,
            short age,
            string passportNumber,
            string gender,
            string phone,
            string email,
            string password
        )
        {
            var client = new Client
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
            };
            clientsList.Add(client);
            Console.WriteLine( "Имя: "+client.FirstName+" Фамилия: "+client.LastName+" Отчество: "+client.MiddleName+" Возраст: "+client.Age);
            return clientsList.FirstOrDefault(client=>client.FirstName == firstName && client.LastName == lastName);
        }
    }
