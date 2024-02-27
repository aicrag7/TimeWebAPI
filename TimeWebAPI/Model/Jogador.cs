using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TimeWebAPI.Model
{
    [Table("Jogador")]
    public class Jogador
    {
        [Key]

        [Column("ID")]
            public int Jogador_id { get; set; }
        [Column("nome")] 
        public string? Nome { get; set; }

        [Column("data_de_nascimento")] 
        public DateFormat DataNascimento { get; set; }

        [Column("numero_da_camiseta")] 
        public int NúmeroCamiseta { get; set; }

        [Column("time_ID")] 
        public Time? TimeId { get; set; }

        [Column("posicao_ID")] 
        public Posição? PosiçãoId { get; set; }
    }
}
