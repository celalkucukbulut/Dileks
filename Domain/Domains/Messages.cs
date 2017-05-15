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
    [Validator(typeof(MessagesValidator))]
    [Table("Messages", Schema = "dbo")]
    public class Messages : AuditableEntity<int>
    {
        public string Name { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
        public string Text { get; set; }
    }

    public class MessagesValidator : AbstractValidator<Messages>
    {
        public MessagesValidator()
        {
            RuleFor(Messages => Messages.Name).NotEmpty().WithMessage("Code is Required").Length(2,50);
            RuleFor(Messages => Messages.Text).NotEmpty().WithMessage("Code is Required").Length(2, 1000);
        }
    }
}
