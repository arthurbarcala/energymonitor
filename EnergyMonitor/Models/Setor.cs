namespace EnergyMonitor.Models
{
    public class Setor
    {
        public int IdSetor { get; set; }
        public string NomeSetor { get; set; }
        public double LimiteConsumo { get; set; }
        public ICollection<Equipamento> Equipamentos { get; set; }
    }
}
