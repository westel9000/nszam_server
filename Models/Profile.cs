using System.Collections.Generic;

namespace ImageWebApp.Models
{
    public class Profile
    {
        public string Bio { get; set; }
        public List<Image> images {
            get;
            set;
        }
    }
}