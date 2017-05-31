using AutoMapper;
using Core.Services.Interfaces;
using Domain.Domains;
using Infrastructure.Interfaces;
using Services.Results;
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

        public ContactResult getAllContactContents()
        {
            var contents = _contentsRepository.getAllContactContents();
            
            Mapper.Initialize(config => { config.CreateMap<IEnumerable<Contents>, ContactResult>().ForMember(x => x.Contents, y => y.MapFrom(z => z)); });
            var result = Mapper.Map<IEnumerable<Contents>, ContactResult>(contents);

            return result;
        }

        public IEnumerable<Contents> getAllContents()
        {
            var contents = _contentsRepository.GetList();
            return contents;
        }

        public IEnumerable<Contents> getAllContentsByDBCode(int dbCode)
        {
            var contents = _contentsRepository.getAllContentsByDBCode(dbCode);
            return contents;
        }

        public IEnumerable<Contents> getAllProductContents()
        {
            var contents = _contentsRepository.getAllProductContents();
            return contents;
        }
    }

}
