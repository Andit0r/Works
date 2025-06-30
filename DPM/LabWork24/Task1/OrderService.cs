// Сервис для работы с заказами
public class OrderService
{
    private List<Order> orders { get; set; } = [];

    public void AddOrder(Order order)
    {
        orders.Add(order);
    }

    public void PrintOrderDetails(int orderId)
    {
        Order? order = GetOrder(orderId);

        if (order == null)
        {
            Console.WriteLine("Заказ не найден.");
            return;
        }

        Console.WriteLine("Номер заказа: " + order.Id);
        Console.WriteLine("Стоимость заказа: " + order.Total);
        Console.WriteLine("Адрес: " + order.Address);
        Console.WriteLine("Экспресс доставка: " + (order.IsExpress ? "Да" : "Нет"));
    }

    private Order? GetOrder(int orderId)
    {
        return orders.FirstOrDefault(o => o.Id == orderId);
    }

    public static void CalculateNds(Order order, out double nds, out double discount)
    {
        nds = 0.2;
        const double DiscountPercentage = 0.1;
        const int MinDiscountOrderAmount = 10000;

        // Расчет скидки
        discount = order.Total > MinDiscountOrderAmount ? order.Total * DiscountPercentage : 0;
    }
}
