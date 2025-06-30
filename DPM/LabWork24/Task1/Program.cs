OrderService orderService = new();

var order = new Order { Total = 1200, IsExpress = true, Address = "Папанина, 24" };
var order2 = new Order { Total = 1200, IsExpress = true };
orderService.AddOrder(order);

orderService.PrintOrderDetails(order.Id);

Console.WriteLine("Полная стоимость: " + order.CalculateNetPrice(order));
Console.WriteLine("Полная стоимость: " + order.CalculateNetPrice(order2));