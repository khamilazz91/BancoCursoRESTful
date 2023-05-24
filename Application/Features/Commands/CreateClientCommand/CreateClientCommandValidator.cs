using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Commands.CreateClientCommand
{
    public  class CreateClientCommandValidator : AbstractValidator<CreateClientCommand>
    {
        public CreateClientCommandValidator()
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

            //salvador
            //RuleFor(p => p.PhoneNumber)
            //   .NotEmpty().WithMessage("{PropertyName} no puede ser vacio")
            //   .Matches(@"^\d{4}-\d{4}$").WithMessage("{PropertyName} debe cumplir el formato +56912345678")
            //   .MaximumLength(80).WithMessage("{PropertyName} no debe exceder de {MaxLength} caracteres");


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
