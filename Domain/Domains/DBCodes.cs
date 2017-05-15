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

    [Validator(typeof(DBCodesValidator))]
    [Table("DBCodes", Schema = "dbo")]
    public class DBCodes : AuditableEntity<int>
    {
        public int Code { get; set; }
        public string About { get; set; }
    }
    public class DBCodesValidator : AbstractValidator<DBCodes>
    {
        public DBCodesValidator()
        {
            RuleFor(dbCodes => dbCodes.Code).NotEmpty().WithMessage("Code is Required");
            RuleFor(dbCodes => dbCodes.About).NotEmpty().WithMessage("Code is Required").Length(2,50);
        }
    }
}
