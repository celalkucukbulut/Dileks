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
        Images getImage(int id);
    }
}
