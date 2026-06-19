namespace EnergyMonitor.Models
{
    public class AlertaConsumo
    {
        public int IdAlerta { get; set; }
        public int IdSetor { get; set; }
        public DateTime DataAlerta { get; set; }
        public string Mensagem { get; set; }
    }
}
