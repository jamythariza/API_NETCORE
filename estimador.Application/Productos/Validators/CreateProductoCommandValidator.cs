using estimador.Application.Productos.Commands;
using FluentValidation;

namespace estimador.Application.Productos.Validators
{
    public class CreateProductoCommandValidator: AbstractValidator<CreateProductoCommand>
    {
        public CreateProductoCommandValidator()
        {
            RuleFor(t => t.referencia).NotEmpty().WithMessage("La referencia es requerida.");
            RuleFor(t => t.nombre).NotEmpty().WithMessage("El nombre es requerido.");
        }
    }
}
