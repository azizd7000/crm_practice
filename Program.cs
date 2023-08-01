using Crm.Entities;
using Crm.Services;
using Crm;

ClientService clientService = new();
CreateClient();
OrderService orderService = new();
CreateOrder();
  static void validateInput (string checkInput ){
        if (checkInput.Length == 0){
        throw new Exception("Поле не может быть пустым");
        }
     }
void CreateClient()
{   

    Console.Write("Имя: ");
    string firstName = Console.ReadLine();

    Console.Write("Фамилия: ");
    string lastName = Console.ReadLine();

    Console.Write("Отчество: ");
    string middleName = Console.ReadLine();

    Console.Write("Возраст: ");
    short age = short.Parse(Console.ReadLine());

    Console.Write("Пасспорт: ");
    string passportNumber = Console.ReadLine();

    Console.Write("Пол: ");
    string gender = Console.ReadLine();

    Client newClient = clientService.CreateClient(
        firstName,
        lastName,
        middleName,
        age,
        passportNumber,
        gender 
    );
    


    Console.WriteLine("Client Info: "+" "+
        string.Join(' ', newClient.FirstName, newClient.MiddleName, newClient.LastName,newClient.Age,newClient.Gender,newClient.PassportNumber));
  
}
void CreateOrder()
{   
    Console.Write("ID_заказа: ");
    string id = Console.ReadLine();
    
    Console.Write("Описание заказа: ");
    string desc = Console.ReadLine();

    Console.Write("Цена заказа: ");
    string price = Console.ReadLine();

    Console.Write("Дата заказа: ");
    string date = Console.ReadLine();

    Console.Write("Тип заказа: ");
    string type = Console.ReadLine();


    Console.Write("Адрес заказа: ");
    string address = Console.ReadLine();
 
   
    
    Order newOrder = orderService.CreateOrder(
        id,
        desc,
        price,
        date,
        type,
        address 
    );
      Console.WriteLine("Order Info: "+" "+
        string.Join(' ', newOrder.Id, newOrder.Desc, newOrder.Price,newOrder.Date,newOrder.Type,newOrder.Address));

}
Console.WriteLine("HW-11");