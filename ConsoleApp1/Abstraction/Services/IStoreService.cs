using ConsoleApp1.Abstraction.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Abstraction.Services
{
    public interface IStoreService
    {
        void SellProduct(IStore s, IClient c, IProduct p, int count);
    }
}
