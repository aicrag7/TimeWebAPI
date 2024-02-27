using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TimeWebAPI.Model
{
    [Table("Time")]
    public class Time
    {
        [Key]
        [Column("ID_2")]
        public int TimeId { get; set; }

        [Column("nome_do_time")] 
        public string? NomeTime { get; set; }
    }
}
