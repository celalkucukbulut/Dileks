using Core.Services.Interfaces;
using Domain.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.ContentsServices
{
    public interface IContentsServices : IService
    {
        IEnumerable<Contents> getAllContents();
    }
}
