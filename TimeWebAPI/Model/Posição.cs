using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TimeWebAPI.Model
{
    [Table("Posicao")]

    public class Posição
    {
        [Key]
        [Column("ID_1")]
        public int PosiçãoId { get; set; }

        [Column("descricao")] 
        public string? Descrição { get; set; }

    }
}
