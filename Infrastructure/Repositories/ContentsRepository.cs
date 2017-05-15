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
    public class ContentsRepository : DapperRepositoryBase<Contents>, IContentsRepository
    {
        public ContentsRepository(DapperHelper dapperHelper) : base(dapperHelper)
        {
        }
    }
}