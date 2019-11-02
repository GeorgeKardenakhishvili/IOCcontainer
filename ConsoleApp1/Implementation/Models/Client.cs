using ConsoleApp1.Abstraction.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Implementation.Models
{
    public class Client : IClient
    {
        public double Money { get; set; }
        public double Coins { get; set; } = 0;
        public IList<IProduct> PurchasedProducts { get; set; } = new List<IProduct>();
    }
}
