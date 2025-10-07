using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf_dev_backend_2025.Models
{

    [Table("Veiculos")]
    public class Veiculo
    {

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o nome")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Obrigatório informar a placa")]
        public string Placa { get; set; }
        [Required(ErrorMessage = "Obrigatório informar o ano de fabricação")]
        public int AnoFaricacao { get; set; }
        [Required(ErrorMessage = "Obrigatório informar o ano de modelo")]
        public int AnoModelo { get; set; }


    }
}
