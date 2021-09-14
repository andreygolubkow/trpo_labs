using System;
using System.Collections.Generic;
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


            while (true)
            {
                Console.WriteLine("Введите название продукта(если хотите закончить ввод - введите 0):");
                var input = Console.ReadLine();
                if (input == "0") break;
                
                    
            }
        }
    }
}