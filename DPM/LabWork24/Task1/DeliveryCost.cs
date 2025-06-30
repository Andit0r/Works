class DeliveryCost
{
    public static double CalculateDelivery(Order order)
    {
        // Расчет стоимости доставки
        double deliveryCost = 0; // Доставка бесплатная, если заказ дороже 3000 рублей
        const int FixedDeliveryCost = 230;
        const int MinFixedDeliveryOrderAmount = 1000;
        const int MinFreeDeliveryOrderAmount = 3000;
        const int ExpressDeliveryMultiplier = 2;

        if (order.Total < MinFixedDeliveryOrderAmount)
            deliveryCost = order.Total;
        else if (order.Total >= MinFixedDeliveryOrderAmount && order.Total < MinFreeDeliveryOrderAmount)
            deliveryCost = FixedDeliveryCost;

        if (order.IsExpress)
            deliveryCost *= ExpressDeliveryMultiplier;

        if (order.Address is null)
            throw new OrderException("Пустой адрес");

        return deliveryCost;
    }
}