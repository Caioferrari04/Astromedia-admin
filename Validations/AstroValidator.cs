using Astromedia_admin.DTO;
using FluentValidation;

namespace Astromedia_admin.Validations;

public class AstroValidator : AbstractValidator<AstroDTO>
{
    public AstroValidator()
    {
        RuleFor(m => m.Nome)
            .NotEmpty()
            .WithMessage("Nome não pode ser vazio.")
            .Length(5, 20);
            

        RuleFor(m => m.Curiosidades)
            .NotEmpty()
            .WithMessage("Curiosidades não pode ser vazio.");

        RuleFor(m => m.Foto)
            .Must(uri => Uri.TryCreate(uri, UriKind.Absolute, out _))
            .When(m => !string.IsNullOrEmpty(m.Foto))
            .WithMessage("Foto deve conter uma url válida");
    }
}