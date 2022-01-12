using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorello.ViewModels
{
    public class BasketVm
    {
        public List<BasketItemVm> basketItemVms { get; set; }
        public double TotalPrice { get; set; }
        public int Count { get; set; }
    }
}
