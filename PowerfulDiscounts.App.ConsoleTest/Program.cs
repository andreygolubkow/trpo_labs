using System;
using PowerfulDiscounts.Model.Common;
using PowerfulDiscounts.Model.Models;

namespace PowerfulDiscounts.App.ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите адрес доставки:");
            Order order = null;
            do
            {
                var address = Console.ReadLine();
                var message = Act.Try(() =>
                {
                    order = Order.Create(address);
                });
                if (message != null)
                {
                    Console.WriteLine(message);
                }
            } while (order == null);
        }
    }
}