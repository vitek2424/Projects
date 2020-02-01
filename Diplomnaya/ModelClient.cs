using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Diplomnaya
{
    [Serializable]
    [Table("Client")]
    public class ModelClient
    {
        [Key]
        public int ClientId { get; set; }
        [Required, MaxLength(20)]
        public string ZakazNumber { get; set; }
        [Required, MaxLength(50)]
        public string FIO { get; set; }
        [Required, MaxLength(14)]
        public string Phone { get; set; }
    }
}
