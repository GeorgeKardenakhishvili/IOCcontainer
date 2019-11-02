using ConsoleApp1.Abstraction.Models;
using ConsoleApp1.Implementation.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using ConsoleApp1.Abstraction.Services;

namespace ConsoleApp1
{
    public static class ExtensionMethods
    {
        public static void SellProducts(this IStore s, IProduct p, int count)
        {
            for(var i = 0; i < count; i++)
            {
                s.Products.Add(p);
                s.Products.Remove(p);
                Console.WriteLine("You bought " + p.Name + ". Price : " + p.Price);
            }
        }

        public static void BuyProducts(this IClient c, IProduct p, int count, IStore s, bool coins)
        {
            if(!coins)
            {
            c.Money -= p.Price * count;
            for(var i = 0; i < count; i++)
            {
            c.Coins = c.Coins + p.Price * 12.5;
                c.PurchasedProducts.Add(p);
            }
            IOCContainer.Get<IStoreService>().SellProduct(s, c, p, count);
            } else
            {
                if(c.Coins > p.Price * 100 * count)
                {
                    c.Coins -= p.Price * 100 * count;
                } else
                {
                    var tmp = p.Price * count;
                    tmp -= c.Coins / 100;
                    c.Coins = 0;
                    c.Money -= tmp;
                }
            }
        }

        public static void ConvertCoins(this IClient c)
        {
            c.Money += c.Coins / 100;
            c.Coins = 0;
        }
    }
}
