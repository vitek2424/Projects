using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Diplomnaya
{
    [Serializable]
    [Table("Car")]
    public class ModelCar
    {
        [Key]
        public int CarId { get; set; }
        [Required, MaxLength(20)]
        public string ZakazNumber { get; set; }
        [Required, MaxLength(14)]
        public string GOS { get; set; }
        [Required]
        public int ReleaseYear { get; set; }
        [Required, MaxLength(30)]
        public string Model { get; set; }
        [Required, MaxLength(30)]
        public string Body { get; set; }
        [Required]
        public double Miliage { get; set; }
        [Required, MaxLength(14)]
        public string Engine { get; set; }
        [Required, MaxLength(14)]
        public string Chassis { get; set; }
        [Required, MaxLength(14)]
        public string VIN { get; set; }
    }
}