using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enum_example
{
    public enum OrderStatus
    {
        Pending,
        Processing,
        Shipped,
        Delivered,
        Cancelled
    }

    internal class Order
    {
        public int OrderID { get; set; }
        public string  CustomerName { get; set; }
        public OrderStatus Status { get; set; }

        public void UpdateStatus(OrderStatus newStatus)
        {
            Status = newStatus;
            Console.WriteLine($"Order status updated to : {Status}");

        }


        public bool IsDelivered()
        {
            return Status == OrderStatus.Delivered;

        }

    }
}
