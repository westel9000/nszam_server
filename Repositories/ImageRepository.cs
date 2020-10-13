using ImageWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImageWebApp.Repositories
{
    public class ImageRepository : IImageRepository
    {
        private List<Image> _images = new List<Image>();
        public ImageRepository()
        {
            _images.Add(new Image { Id = 1, Content = "Teszt Elek", Created = DateTime.Now });
            _images.Add(new Image { Id = 2, Content = "Teszt Eva", Created = DateTime.Now });
        }
        public List<Image> GetAll()
        {
            return _images;
        }
        public Image GetById(int id)
        {
            return _images.FirstOrDefault(e => e.Id == id);
        }
    }
}
