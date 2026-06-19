namespace EnergyMonitor.Models
{
    public class ConsumoEnergia
    {
        public int IdConsumo { get; set; }
        public int IdEquipamento { get; set; }
        public DateTime DataRegistro { get; set; }
        public double ConsumoKwh { get; set; }
    }
}
