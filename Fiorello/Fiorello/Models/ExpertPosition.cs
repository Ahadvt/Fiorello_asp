using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorello.Models
{
    public class ExpertPosition
    {
        public int Id { get; set; }
        public string Position { get; set; }
        public List<Expertt> Expertts { get; set; }
    }
}
