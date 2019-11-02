using ConsoleApp1.Abstraction.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Implementation.Models
{
    class Product : IProduct
    {
        public string Name { get; set; }
        public double Price { get; set; } = 5;
    }
}
