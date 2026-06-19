namespace EnergyMonitor.Models
{
    public class Equipamento
    {
        public int IdEquipamento { get; set; }
        public string NomeEquipamento { get; set; }
        public string StatusEquipamento { get; set; }
        public int IdSetor { get; set; }
        public Setor Setor { get; set; }
    }
}
