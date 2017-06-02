using Core.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Domains;
namespace Services.ImagesServices
{
    public interface IImagesServices : IService
    {
        IEnumerable<Images> getAllImages();
        IEnumerable<Images> getAllProducts();
        IEnumerable<Images> getImagesByDBCodes(int dbCode);
        Images getImage(int id);
        void InsertSliderImage(string path, string text);
    }
}
