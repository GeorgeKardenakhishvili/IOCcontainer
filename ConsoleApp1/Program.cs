using ConsoleApp1;
using ConsoleApp1.Abstraction.Models;
using ConsoleApp1.Abstraction.Services;
using ConsoleApp1.Implementation.Models;
using ConsoleApp1.Implementation.Services;
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            IOCContainer.AddAsSingleton<IStoreService>(() => new StoreService());
            var giorgi = new Client()
            {
                Money = 1000
            };

            var Store = new Store();

            giorgi.BuyProducts(new Product() { Name = "Apple" }, 20, Store, false);
            Console.WriteLine(giorgi.Coins + " " + giorgi.Money);
            giorgi.BuyProducts(new Product() { Name = "Apple" }, 20, Store, true);
            Console.WriteLine(giorgi.Coins + " " + giorgi.Money);

            Console.ReadKey();
        }
    }
}
