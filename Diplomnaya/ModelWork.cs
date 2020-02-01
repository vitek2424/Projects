using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Diplomnaya
{
    [Serializable]
    [Table("Work")]
    public class ModelWork
    {
        [Key]
        public int WorkId { get; set; }
        [Required, MaxLength(20)]
        public string ZakazNumber { get; set; }
        [Required, MaxLength(30)]
        public string NameWorks { get; set; }
        [Required]
        public double QuantityHours { get; set; }
        [Required]
        public double Amount { get; set; }
        [Required]
        public double Summ { get; set; }
    }
}
