using AgencyVilla.Entity.Entities;
using FluentValidation;

namespace AgencyVilla.Business.Validators;

public class QuestionValidator : AbstractValidator<Quest>
{
    public QuestionValidator()
    {
        RuleFor(x => x.Question).NotEmpty().WithMessage("Soru Boş Bırakılamaz");
        RuleFor(x => x.Question).MinimumLength(10).WithMessage("Soru 10 Karakterden Az Olamaz");
        RuleFor(x => x.Question).MaximumLength(100).WithMessage("Soru 100 Karakterden Fazla Olamaz");
        RuleFor(x => x.Answer).NotEmpty().WithMessage("Cevap Boş Bırakılamaz");
        RuleFor(x => x.Answer).MinimumLength(7).WithMessage("Cevap 7 Karakterden Az Olamaz");
        RuleFor(x => x.Answer).MaximumLength(100).WithMessage("Soru 100 Karakterden Fazla Olamaz");
    }
}
