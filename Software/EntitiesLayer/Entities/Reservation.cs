namespace EntitiesLayer.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("Reservation")]
    public partial class Reservation
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public int customerID { get; set; }

        public int vehicleID { get; set; }

        public DateTime pickupDate { get; set; }

        public DateTime? returnDate { get; set; }

        [Required]
        [StringLength(50)]
        public string pickupLocation { get; set; }

        [Required]
        [StringLength(50)]
        public string returnLocation { get; set; }

        public decimal? totalCost { get; set; }

        public DateTime? creationDate { get; set; }

        [StringLength(50)]
        public string status { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Vehicle Vehicle { get; set; }
    }
}
