using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf_apis_wbe_services_fuel_manager.Models
{
    [Table("Consumos")]
    public class Consumo
    {

        [Key]
        public int Id { get; set; }

        public string Descricao { get; set; }
        [Required]
        public DataType Data { get; set; }
        [Required]
        public decimal Valor { get; set; }
        [Required]
        public TipoCombustível Tipo { get; set; }
        [Required]
        public int VeiculoId { get; set; }
        public Veiculo Veiculo { get; set; }







    }
    public enum TipoCombustível
    {
        Diesel, 
        Etanol,
        Gasolina
    }
}
