using System;


class Order
{
    public int OrderId;
    public string OrderDate;


    public Order(int id, string date)
    {
        OrderId = id;
        OrderDate = date;
    }


    public virtual void GetOrderStatus()
    {
        Console.WriteLine("Order Placed");
    }
}



class ShippedOrder : Order
{
    public string TrackingNumber;


    public ShippedOrder(
        int id,
        string date,
        string tracking)
        : base(id, date)
    {
        TrackingNumber = tracking;
    }


    public override void GetOrderStatus()
    {
        Console.WriteLine("Order Shipped");
    }
}



class DeliveredOrder : ShippedOrder
{
    public string DeliveryDate;


    public DeliveredOrder(
        int id,
        string date,
        string tracking,
        string delivery)
        : base(id, date, tracking)
    {
        DeliveryDate = delivery;
    }


    public override void GetOrderStatus()
    {
        Console.WriteLine("Order Delivered");
        Console.WriteLine("Delivery Date: " + DeliveryDate);
    }
}



class Program
{
    static void Main(string[] args)
    {
        DeliveredOrder order =
            new DeliveredOrder(
                1,
                "01-08-2026",
                "TRK12345",
                "04-08-2026"
            );


        order.GetOrderStatus();
    }
}