using ConsoleApp1.Abstraction.Models;
using ConsoleApp1.Abstraction.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Implementation.Services
{
    class StoreService : IStoreService
    {
        public void SellProduct(IStore s, IClient c, IProduct p, int count)
        {
            s.SellProducts(p, count);
            c.Money -= p.Price;
            c.Coins += p.Price * 12.5;
        }
    }
}
