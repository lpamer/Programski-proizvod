namespace EntitiesLayer.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("Support")]
    public partial class Support
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int user { get; set; }

        public int? employee { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(150)]
        public string message { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime message_date { get; set; }

        [StringLength(150)]
        public string answer { get; set; }

        public DateTime? answer_date { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Employee Employee1 { get; set; }
    }
}
