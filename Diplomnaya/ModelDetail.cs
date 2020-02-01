using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Diplomnaya
{
    [Serializable]
    [Table("Detail")]
    public class ModelDetail
    {
        [Key]
        public int DetailId { get; set; }
        [Required, MaxLength(20)]
        public string ZakazNumber { get; set; }
        [Required, MaxLength(35)]
        public string NameDetails { get; set; }
        [Required, MaxLength(15)]
        public string Unit { get; set; }
        [Required]
        public double Quantity { get; set; }
        [Required]
        public double Amount { get; set; }
        [Required]
        public double Summ { get; set; }
    }

}
