using ImageWebApp.Models;
using System.Collections.Generic;

namespace ImageWebApp.Repositories
{
    public interface IImageRepository
    {
        List<Image> GetAll();
        Image GetById(int id);
    }
}