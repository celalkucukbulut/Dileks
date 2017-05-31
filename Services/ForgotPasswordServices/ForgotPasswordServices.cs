using Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.ForgotPasswordServices
{
    public class ForgotPasswordServices : IForgotPasswordServices
    {
        private readonly IForgotPasswordRepository _forgotPasswordRepository;
        private readonly IAdminsRepository _adminsRepository;
        public ForgotPasswordServices(IForgotPasswordRepository forgotPasswordRepository,
            IAdminsRepository adminsRepository)
        {
            _forgotPasswordRepository = forgotPasswordRepository;
            _adminsRepository = adminsRepository;
        }
        public string GetHashCodes(int AdminId)
        {
        }
    }
}
