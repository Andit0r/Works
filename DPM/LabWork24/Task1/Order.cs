// заказ
public class Order
{
    public int Id;
    private double _total;
    public bool IsExpress;
    private string _address;

    public double Total
    {
        get => _total;
        set
        {
            if (value > 0)
                _total = value;
        }
    }

    public string Address
    {
        get => _address;
        set
        {
            if (value.Trim() != "")
                _address = value;
        }
    }

    public double CalculateNetPrice(Order order)
    {
        double nds, discount;
        OrderService.CalculateNds(order, out nds, out discount);
        double deliveryCost = DeliveryCost.CalculateDelivery(order);

        return order.Total - discount + order.Total * nds + deliveryCost;
    }
}
