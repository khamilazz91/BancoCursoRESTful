using FluentValidation;

namespace Application.Features.Commands.UpdateClientCommand
{
    public class UpdateClientCommandValidator : AbstractValidator<UpdateClientCommand>
    {
        public UpdateClientCommandValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty().WithMessage("{PropertyName} no puede ser vacio")
                .MaximumLength(80).WithMessage("{PropertyName} no debe exceder de {MaxLength} caracteres");

            RuleFor(p => p.LastName)
                .NotEmpty().WithMessage("{PropertyName} no puede ser vacio")
                .MaximumLength(80).WithMessage("{PropertyName} no debe exceder de {MaxLength} caracteres");

            RuleFor(p => p.BirthDate)
                .NotEmpty().WithMessage("{PropertyName} no puede ser vacio");
            //chile
            RuleFor(p => p.PhoneNumber)
                .NotEmpty().WithMessage("{PropertyName} no puede ser vacio")
                .Matches(@"^\+?56[1-9]\d{1}\d{7}$").WithMessage("{PropertyName} debe cumplir el formato +56912345678")
                .MaximumLength(12).WithMessage("{PropertyName} no debe exceder de {MaxLength} caracteres");

            RuleFor(p => p.Email)
               .NotEmpty().WithMessage("{PropertyName} no puede ser vacio")
               .EmailAddress().WithMessage("{PropertyName} debe ser una direccion de correo valida")
               .MaximumLength(80).WithMessage("{PropertyName} no debe exceder de {MaxLength} caracteres");

            RuleFor(p => p.Adress)
               .NotEmpty().WithMessage("{PropertyName} no puede ser vacio")
               .MaximumLength(80).WithMessage("{PropertyName} no debe exceder de {MaxLength} caracteres");
        }
    }
}
