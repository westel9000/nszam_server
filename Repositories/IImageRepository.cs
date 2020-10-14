using ImageWebApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ImageWebApp.Repositories
{
    public interface IImageRepository
    {
        List<Image> GetAll();
        Image GetById(int id);
        void Add(Image image);
    }
}