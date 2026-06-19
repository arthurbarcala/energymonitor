using EnergyMonitor.ViewModels;
using FluentValidation;

namespace EnergyMonitor.Validators
{
    public class ConsumoValidator : AbstractValidator<ConsumoCreateViewModel>
    {
        public ConsumoValidator()
        {
            RuleFor(x => x.IdEquipamento)
                .GreaterThan(0)
                .WithMessage("Id do equipamento inválido");

            RuleFor(x => x.ConsumoKwh)
                .GreaterThan(0)
                .WithMessage("Consumo deve ser maior que zero");
        }
    }
}