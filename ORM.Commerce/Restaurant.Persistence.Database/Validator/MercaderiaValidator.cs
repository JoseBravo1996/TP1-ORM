using FluentValidation;
using Restaurant.Domain;

namespace Restaurant.Persistence.Database.Validator
{
    public class MercaderiaValidator : AbstractValidator<Mercaderia>
    {
        public MercaderiaValidator() 
        {
            RuleFor(x => x.Nombre).NotEmpty()
                       .MaximumLength(50)
                       .WithMessage("El maximo es 50 caracteres.");

            RuleFor(x => x.Ingredientes).NotEmpty()
                       .MaximumLength(255)
                       .WithMessage("El maximo es 255 caracteres.");

            RuleFor(x => x.Preparacion).NotEmpty()
                       .MaximumLength(255)
                       .WithMessage("El maximo es 255 caracteres.");

            RuleFor(x => x.Imagen).NotEmpty()
                       .MaximumLength(255)
                       .WithMessage("El maximo es 255 caracteres.");
        }
    }
}
