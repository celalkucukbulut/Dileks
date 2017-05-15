﻿using Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Domains;

namespace Services.ImagesServices
{
    public class ImagesServices : IImagesServices
    {
        #region .ctor
        private readonly IImagesRepository _imagesRepository;
        
        public ImagesServices(IImagesRepository imagesRepository)
        {
            _imagesRepository = imagesRepository;
        }
        #endregion
        public IEnumerable<Images> getAllImages()
        {
            var images = _imagesRepository.GetList();
            return images;
        }

        public Images getImage(int id)
        {
            var image = _imagesRepository.Get(id);
            return image;
        }
    }
}