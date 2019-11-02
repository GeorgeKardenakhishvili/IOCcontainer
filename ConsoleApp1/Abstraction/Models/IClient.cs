using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Abstraction.Models
{
    public interface IClient
    {
        double Money { get; set; }
        double Coins { get; set; }
        IList<IProduct> PurchasedProducts { get; set; }
    }
}
