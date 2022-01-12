using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorello.Models
{
    public class Expertt
    {
        public int Id { get; set; }
        public string Img { get; set; }
        public string Name { get; set; }

        public int ExpertPositionId { get; set; }
        public ExpertPosition expertPosition { get; set; }
    }
}
