using FluentValidation;
using Restaurant.Domain;

namespace Restaurant.Persistence.Database.Validator
{
    public class TipoMercaderiaValidator : AbstractValidator<TipoMercaderia>
    {
        public TipoMercaderiaValidator()
        {
            RuleFor(x => x.Descripcion).NotEmpty()
                       .MaximumLength(50)
                       .WithMessage("El maximo es 50 caracteres.");
        }
    }
}
