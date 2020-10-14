using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImageWebApp.Models
{
    public class Image
    {
        public static int currentId = 0;
        public int Id {
            get;
            set;
        }

        public string Owner { get; set; }
        public string Content { get; set; }
        public DateTime Created { get; set; }
    }
}
