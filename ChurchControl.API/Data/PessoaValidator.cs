// Validators/PessoaValidator.cs
using FluentValidation;
using ChurchControl.API.Data;

public class PessoaValidator : AbstractValidator<Pessoa>
{
    public PessoaValidator()
    {
        RuleFor(pessoa => pessoa.Nome)
            .NotEmpty().WithMessage("O nome é obrigatório.");

        RuleFor(pessoa => pessoa.Sexo)
            .NotEmpty().WithMessage("O sexo é obrigatório.");

        RuleFor(pessoa => pessoa.DataNascimento)
            .NotEmpty().WithMessage("A data de nascimento é obrigatória.");

        RuleFor(pessoa => pessoa.Telefone)
            .Matches(@"^\(\d{2}\) \d{4,5}-\d{4}$").WithMessage("O telefone deve estar no formato (XX) XXXX-XXXX ou (XX) XXXXX-XXXX.");

        RuleFor(pessoa => pessoa.Celular)
            .NotEmpty().WithMessage("O celular é obrigatório.")
            .Matches(@"^\(\d{2}\) \d{4,5}-\d{4}$").WithMessage("O celular deve estar no formato (XX) XXXX-XXXX ou (XX) XXXXX-XXXX.");

        RuleFor(pessoa => pessoa.Email)
            .EmailAddress().WithMessage("O email não é válido.");

        RuleFor(pessoa => pessoa.Cep)
            .NotEmpty().WithMessage("O CEP é obrigatório.");

        RuleFor(pessoa => pessoa.Estado)
            .NotEmpty().WithMessage("O estado é obrigatório.");

        RuleFor(pessoa => pessoa.Cidade)
            .NotEmpty().WithMessage("A cidade é obrigatória.");

        RuleFor(pessoa => pessoa.Bairro)
            .NotEmpty().WithMessage("O bairro é obrigatório.");

        RuleFor(pessoa => pessoa.Logradouro)
            .NotEmpty().WithMessage("O logradouro é obrigatório.");

        RuleFor(pessoa => pessoa.Numero)
            .NotEmpty().WithMessage("O número é obrigatório.");
    }
}
