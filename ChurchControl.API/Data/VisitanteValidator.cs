// Validators/VisitanteValidator.cs
using FluentValidation;
using ChurchControl.API.Data;

public class VisitanteValidator : AbstractValidator<Visitante>
{
    public VisitanteValidator()
    {
        Include(new PessoaValidator());

        RuleFor(visitante => visitante.IdUnidade)
            .NotEmpty().WithMessage("O IdUnidade é obrigatório.");

        RuleFor(visitante => visitante.DataVisita)
            .NotEmpty().WithMessage("A data de visita é obrigatória.");
    }
}
