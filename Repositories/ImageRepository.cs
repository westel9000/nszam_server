using ImageWebApp.Models;
using Microsoft.AspNetCore.Http; // IFormFile
using System;
using System.Collections.Generic;
using System.IO;
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
            Add(new Image { Content = File.ReadAllText("assets/im1"), Created = DateTime.Now, Owner = "User 1"});
            Add(new Image { Content = File.ReadAllText("assets/im2"), Created = DateTime.Now, Owner = "User 2"});
            Add(new Image { Content = File.ReadAllText("assets/im3"), Created = DateTime.Now, Owner = "User 3"});
            Add(new Image { Content = File.ReadAllText("assets/im3"), Created = DateTime.Now, Owner = "User 1"});
            Add(new Image { Content = File.ReadAllText("assets/im2"), Created = DateTime.Now, Owner = "User 2"});
            Add(new Image { Content = File.ReadAllText("assets/im1"), Created = DateTime.Now, Owner = "User 3"});
            Add(new Image { Content = File.ReadAllText("assets/im2"), Created = DateTime.Now, Owner = "User 1"});
            Add(new Image { Content = File.ReadAllText("assets/im1"), Created = DateTime.Now, Owner = "User 2"});
            Add(new Image { Content = File.ReadAllText("assets/im3"), Created = DateTime.Now, Owner = "User 3"});
            Add(new Image { Content = File.ReadAllText("assets/im1"), Created = DateTime.Now, Owner = "User 1"});
            Add(new Image { Content = File.ReadAllText("assets/im3"), Created = DateTime.Now, Owner = "User 2"});
            Add(new Image { Content = File.ReadAllText("assets/im2"), Created = DateTime.Now, Owner = "User 3"});
            Add(new Image { Content = File.ReadAllText("assets/im1"), Created = DateTime.Now, Owner = "User 1"});
            Add(new Image { Content = File.ReadAllText("assets/im3"), Created = DateTime.Now, Owner = "User 2"});
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
    }
}
