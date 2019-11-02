using ConsoleApp1.Abstraction.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Implementation.Models
{
    class Store : IStore
    {
        public IList<IProduct> Products { get; set; } = new List<IProduct>();
    }
}
