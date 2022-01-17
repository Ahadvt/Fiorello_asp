using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorello.Areas.Exstensions
{
    public static class FileMAnager
    {
        public static bool IsImg(this IFormFile file)
        {
            return file.ContentType.Contains("image/");
        }

        public static bool IsSizeOkey(this IFormFile file, int s)
        {
            return file.Length / 1024 / 1024 <= 2;
        }

        public static string SaveImg(this IFormFile file, string root,string folder)
        {
            string Rootpath = Path.Combine(root, folder);
            string FileName = Guid.NewGuid().ToString() + file.FileName;

            string FullPath = Path.Combine(Rootpath, FileName);
            using (FileStream fileStream = new FileStream(FullPath, FileMode.Create))
            {
                file.CopyTo(fileStream);

            }
            return FileName;

        }
    }
}
