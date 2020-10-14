using ImageWebApp.Models;
using Microsoft.AspNetCore.Http; // IFormFile
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImageWebApp.Repositories
{
    public class ImageRepository : IImageRepository
    {
        private List<Image> _images = new List<Image>();
        //private readonly ComputerVisionClient visionClient;
        public ImageRepository()
        {
            Add(new Image { Content = "Teszt Elek", Created = DateTime.Now });
            Add(new Image { Content = "Teszt Eva", Created = DateTime.Now });
        }

        public void Add(Image image)
        {
            image.Id = Image.currentId++;
            _images.Add(image);
        }

        public List<Image> GetAll()
        {
            return _images;
        }
        public Image GetById(int id)
        {
            return _images.FirstOrDefault(e => e.Id == id);
        }

        //public void SaveImage(IFormFile file, User user)
        //{
        //    var bytes = new byte[file.Length];

        //    List<string> tags = new List<string>();
        //    using (var stream = file.OpenReadStream())
        //    {
        //        stream.Read(bytes, 0, bytes.Length);
        //        stream.Seek(0, System.IO.SeekOrigin.Begin);
        //    }
        //    var img = new Image { Content = Convert.ToBase64String(bytes), Owner = user };

        //    if (user.PostedImages == null)
        //    {
        //        user.PostedImages = new List<Image>();
        //    }
        //    _images.Add(img);

        //    //this.imageRepository.Save(img);
        //}
    }
}
