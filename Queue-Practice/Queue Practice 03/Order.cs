using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Practice_03
{
    internal class Order
    {
        // Order ID
        public int OrderId { get; set; }

        // Quantity of the order
        public int OrderQuantity { get; set; }

        // Simple Contructor
        public Order(int id, int orderQuantity)
        {
            OrderId = id;
            OrderQuantity = orderQuantity;
        }

        // Print message on the screen that the order was processed
        public void ProcessOrder()
        {
            Console.WriteLine($"Order {OrderId} processed!.");
        }
    }
}

