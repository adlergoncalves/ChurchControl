// Validators/MedsValidator.cs
using FluentValidation;
using ChurchControl.API.Data;

public class MedsValidator : AbstractValidator<Meds>
{
    public MedsValidator()
    {
        Include(new PessoaValidator());

        RuleFor(meds => meds.IdUnidade)
            .NotEmpty().WithMessage("O IdUnidade é obrigatório.");

        RuleFor(meds => meds.Data)
            .NotEmpty().WithMessage("A data é obrigatória.");

        RuleFor(meds => meds.DataConversao)
            .NotEmpty().WithMessage("A data de conversão é obrigatória.");
    }
}
