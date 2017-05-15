using Core.Services.Interfaces;
using Domain.Domains;
using Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.ContentsServices
{
    public class ContentsServices : IContentsServices
    {
        private readonly IContentsRepository _contentsRepository;

        public ContentsServices(IContentsRepository contentsRepository)
        {
            _contentsRepository = contentsRepository;
        }


        public IEnumerable<Contents> getAllContents()
        {
            var contents = _contentsRepository.GetList();
            return contents;
        }
    }

}
