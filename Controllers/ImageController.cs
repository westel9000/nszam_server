using ImageWebApp.Models;
using ImageWebApp.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

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
        [Microsoft.AspNetCore.Mvc.HttpGet]
        public Microsoft.AspNetCore.Mvc.JsonResult GetImages()
        {
            //return new JsonResult(new Image { Id = 1, Created = DateTime.Now, Content = "Teszt" }); // Teszt helyett majd base64 image string később.
            return new Microsoft.AspNetCore.Mvc.JsonResult(_imageRepository.GetAll());
        }
        [Microsoft.AspNetCore.Mvc.HttpGet("{id}")]
        public Microsoft.AspNetCore.Mvc.JsonResult GetImage(int id)
        {
            return new Microsoft.AspNetCore.Mvc.JsonResult(_imageRepository.GetById(id));
        }

        [HttpPost]
        public Microsoft.AspNetCore.Mvc.JsonResult PostImage([FromBody] Image image)
        {

            _imageRepository.Add(image);
            return new JsonResult("ok");
        }

        //[Microsoft.AspNetCore.Mvc.HttpPost]
        //[Microsoft.AspNetCore.Mvc.Route("new")]
        //public System.Web.Mvc.ActionResult Upload(ImageDTO imageDTO)
        //{

        //    try
        //    {
        //        //_imageRepository.SaveImage(imageDTO);
        //        return new HttpStatusCodeResult(HttpStatusCode.OK);
        //    }
        //    catch (Exception ex)
        //    {

        //        //return BadRequestResult(ex);
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //}
    }
}
