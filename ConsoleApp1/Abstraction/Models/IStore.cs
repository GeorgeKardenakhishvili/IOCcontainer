using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Abstraction.Models
{
    public interface IStore
    {
        IList<IProduct> Products { get; set; }
    }
}
