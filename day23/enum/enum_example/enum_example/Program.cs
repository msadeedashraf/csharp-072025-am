//Change the name of the namespace to your project name
namespace enum_example
{
    internal class Program
    {

        static void Main(string[] arg)
        {
            //Console.WriteLine("Hello World");

            Order order = new Order()
            {
                OrderID = 1001,
                CustomerName = "Chris",
                Status = OrderStatus.Pending
            };

            Console.WriteLine($"Initial Order Status: {order.Status}");

            order.UpdateStatus(OrderStatus.Processing);
            

            order.UpdateStatus(OrderStatus.Shipped);
            
            order.UpdateStatus(OrderStatus.Delivered);


            if (order.IsDelivered())
            {
                Console.WriteLine($"Notify Customer: Your Package has been divered.");
            }





        }

    }
}