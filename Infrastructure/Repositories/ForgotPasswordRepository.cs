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
    public class ForgotPasswordRepository : DapperRepositoryBase<ForgotPassword>, IForgotPasswordRepository
    {
        public ForgotPasswordRepository(DapperHelper dapperHelper) : base(dapperHelper)
        {
        }
    }
}
