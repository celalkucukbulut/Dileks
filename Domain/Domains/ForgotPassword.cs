using Core.Domains;
using FluentValidation;
using FluentValidation.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Domains
{
    [Validator(typeof(ForgotPasswordValidator))]
    [Table("ForgotPassword", Schema = "dbo")]
    public class ForgotPassword : AuditableEntity<int>
    {
        public Guid GUID1 { get; set; }
        public Guid GUID2 { get; set; }
        public Guid GUID3 { get; set; }
        public int AdminId { get; set; }
    }

    public class ForgotPasswordValidator : AbstractValidator<ForgotPassword>
    {
        public ForgotPasswordValidator()
        {
            RuleFor(content => content.GUID1).NotEmpty().WithMessage("GUID1 is Required");
            RuleFor(content => content.GUID2).NotEmpty().WithMessage("GUID2 is Required");
            RuleFor(content => content.GUID3).NotEmpty().WithMessage("GUID3 is Required");
            RuleFor(content => content.AdminId).NotEmpty().WithMessage("AdminId is Required");
        }
    }
}
