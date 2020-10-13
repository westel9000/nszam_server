using ImageWebApp.Models;
using ImageWebApp.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImageWebApp.Controllers
{
    [Route("api/[controller]")]
    public class ImagesController
    {
        private readonly IImageRepository _imageRepository;
        // private List<Image> _images = new List<Image>();

        public ImagesController(IImageRepository imageRepository)
        {
            _imageRepository = imageRepository;
        }
        [HttpGet]
        public JsonResult GetImages()
        {
            //return new JsonResult(new Image { Id = 1, Created = DateTime.Now, Content = "Teszt" }); // Teszt helyett majd base64 image string később.
            return new JsonResult(_imageRepository.GetAll());
        }
        [HttpGet("{id}")]
        public JsonResult GetImage(int id)
        {
            return new JsonResult(_imageRepository.GetById(id));
        }
    }
}
