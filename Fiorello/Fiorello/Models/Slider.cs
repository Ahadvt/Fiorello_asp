using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorello.Models
{
    public class Slider
    {
        public int Id { get; set; }
        public int Order { get; set; }
        public string Img { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string SignatureImg { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
        [NotMapped]
        public IFormFile SignatuteImgFile { get; set; }

    }
}
