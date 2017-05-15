using Core.Repositories.Dapper;
using Domain.Domains;
using Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class ImagesRepository : DapperRepositoryBase<Images> , IImagesRepository
    {
        public ImagesRepository(DapperHelper dapperHelper) : base(dapperHelper)
        {
        }
    }
}
