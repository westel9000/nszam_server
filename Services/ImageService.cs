using ImageWebApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImageWebApp.Services
{
    public class ImageService
    {
        private readonly IImageRepository _imageRepository;
        private readonly IUserRepository _userRepository;
        public ImageService(IImageRepository imageRepository, IUserRepository userRepository)
        {
            _imageRepository = imageRepository;
            _userRepository = userRepository;
        }
        public void GetAll()
        {
            
        }
    }
}
