using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Abstraction.Models
{
    public interface IProduct
    {
        string Name { get; set; }
        double Price { get; set; }
    }
}
