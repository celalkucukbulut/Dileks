using Core.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.ForgotPasswordServices
{
    public interface IForgotPasswordServices : IService
    {
        string GetHashCodes(int AdminId);
    }
}
