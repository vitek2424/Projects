using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Diplomnaya
{
    [Serializable]
    [Table("Zakaz")]
    public class ModelZakaz
    {
        [Key]
        public int ZakazId { get; set; }
        [Required, MaxLength(20)]
        public string ZakazNumber { get; set; }
        [Required, MaxLength(30)]
        public string Client { get; set; }
        [Required]
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
    }
}
