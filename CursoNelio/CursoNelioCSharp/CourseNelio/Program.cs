using CourseNelio.Entities;
using CourseNelio.Entities.Enums;
using System;

namespace CourseNelio
{
    class Program
    {
        static void Main(string[] args)
        {

            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendindPayment
            };
            Console.WriteLine(order);

            string txt = OrderStatus.PendindPayment.ToString();

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(os);
            Console.WriteLine(txt);
        }
    }
}
