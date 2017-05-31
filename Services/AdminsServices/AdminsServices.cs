using Domain.Domains;
using Infrastructure.Interfaces;
using Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace Services.AdminsServices
{
    public class AdminsServices : IAdminsServices
    {
        private readonly IAdminsRepository _adminRepository;
        private readonly IForgotPasswordRepository _forgotPasswordRepository;
        public AdminsServices(IAdminsRepository adminRepository,
            IForgotPasswordRepository forgotPasswordRepository)
        {
            _adminRepository = adminRepository;
            _forgotPasswordRepository = forgotPasswordRepository;
        }
        public bool CheckLogin(string username, string password,ref Admin admin)
        {
            var result = _adminRepository.Login(username, password);
            if (result == null)
                return false;
            admin = result;
            return true;
        }

        public bool CheckUserExist(string mailAddress)
        {
            var result = _adminRepository.checkUserExist(mailAddress);
            return result;
        }

        public bool SendMail(string mailAddress)
        {
            var admin = _adminRepository.getAdminByEmail(mailAddress);
            try
            {
                Guid GUID1 = Guid.NewGuid();
                Guid GUID2 = Guid.NewGuid();
                Guid GUID3 = Guid.NewGuid();
                var forgot = new ForgotPassword()
                {
                    CreatedDate = DateTime.Now,
                    AdminId = admin.ID,
                    GUID1 = GUID1,
                    GUID2 = GUID2,
                    GUID3 = GUID3
                };
                _forgotPasswordRepository.Add(forgot);
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("celalkucukbulut@gmail.com");
                mail.To.Add(mailAddress);
                mail.Subject = "Şifre Yenileme";
                mail.Body = @"Merhaba "+admin.Name + " " + admin.Surname + @",

Şifrenizi aşağıdaki linke tıklayarak yeniden oluşturabilirsiniz.

http://localhost:3417/Admin/Giriş/ŞifreYenile?hash="+GUID1+GUID2+GUID3+@"

İyi Günler.";

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("celalkucukbulut@gmail.com", "medalofhonor");
                SmtpServer.EnableSsl = true;
                SmtpServer.Timeout = 20000;

                SmtpServer.Send(mail);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
