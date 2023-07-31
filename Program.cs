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
    string orderId = Console.ReadLine();
    
    Console.Write("Описание заказа: ");
    string orderDesc = Console.ReadLine();

    Console.Write("Цена заказа: ");
    string orderPrice = Console.ReadLine();

    Console.Write("Дата заказа: ");
    string orderDate = Console.ReadLine();

    Console.Write("Тип заказа: ");
    string orderType = Console.ReadLine();


    Console.Write("Адрес заказа: ");
    string orderAddress = Console.ReadLine();
 
    
    Order newOrder = orderService.CreateOrder(new OrderInfo(){
        Id = orderId,
        Desc = orderDesc,
        Price = orderPrice,
        Date = orderDate,
        Type = orderType,
        Address = orderAddress

    });
      Console.WriteLine("Order Info: "+" "+
        string.Join(' ', newOrder.OrderId, newOrder.OrderDesc, newOrder.OrderPrice,newOrder.OrderDate,newOrder.OrderType,newOrder.OrderAddress));

}
