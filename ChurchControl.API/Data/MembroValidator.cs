// Validators/MembroValidator.cs
using FluentValidation;
using ChurchControl.API.Data;

public class MembroValidator : AbstractValidator<Membro>
{
    public MembroValidator()
    {
        Include(new PessoaValidator());

        RuleFor(membro => membro.IdUnidade)
            .NotEmpty().WithMessage("O IdUnidade é obrigatório.");

        RuleFor(membro => membro.Status)
            .NotEmpty().WithMessage("O status é obrigatório.");

        RuleFor(membro => membro.DataCadastro)
            .NotEmpty().WithMessage("A data de cadastro é obrigatória.");
    }
}
