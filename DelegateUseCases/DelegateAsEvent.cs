using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateUseCase
{
    class MyOrders
    {
        public delegate void OrderHandeler(int OrderId);
        public event OrderHandeler Order;

        void PlaceOrder(string OrderInfo)
        {
            Console.WriteLine("Order Info:- " + OrderInfo);

            int orderId = new Random().Next();
            // on Order placed done , lets fire Order Event
            //Order(orderId);   // __. Invoke event
            if (Order != null)
            { Order(orderId); }
            else
            {
                Console.WriteLine("Order Event is not handeled");
            }
        }


        public void Main()
        {
            Console.WriteLine("Enter Order Info");
            string orderinfo = Console.ReadLine();

            MyOrders myorder = new MyOrders();
            myorder.Order += Myorder_Order;
            myorder.PlaceOrder(orderinfo);
        }

        private void Myorder_Order(int OrderId)
        {
            Console.WriteLine("Order Placed Successfully, Order-ID = " + OrderId);
        }

    }
}
