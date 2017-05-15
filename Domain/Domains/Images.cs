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
    [Validator(typeof(ImagesValidator))]
    [Table("Images", Schema = "dbo")]
    public class Images  : AuditableEntity<int>
    {
        public string Code { get; set; }
        public string FilePath { get; set; }
        public string Text { get; set; }
        public int DBCode { get; set; }
    }

    public class ImagesValidator : AbstractValidator<Images>
    {
        public ImagesValidator()
        {
            RuleFor(image => image.FilePath).NotEmpty().WithMessage("Title is Required").Length(2, 100);
            RuleFor(image => image.DBCode).NotEmpty().WithMessage("DBCode is Required");
        }
    }

}
