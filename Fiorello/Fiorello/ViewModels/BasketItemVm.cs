using Fiorello.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorello.ViewModels
{
    public class BasketItemVm
    {
        public Product Product { get; set; }
        public int Count { get; set; }
        public double Price { get; set; }
    }
}
