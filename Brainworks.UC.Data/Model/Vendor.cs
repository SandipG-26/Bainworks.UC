using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Brainworks.UC.Data
{
    public class Vendor
    {
        public int ID { get; set; }

        [Column(TypeName = "varchar(20)")]
        [Required]
        public string FirstName { get; set; }

        [Column(TypeName = "varchar(20)")]
        [Required]
        public string ShopName { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Required]
        public string Address { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Required]
        public string Landmark { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Required]
        public string City { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Required]
        public string State { get; set; }

        [Column(TypeName = "varchar(6)")]
        [Required]
        public string Pin { get; set; }

        [Column(TypeName = "varchar(12)")]
        [Required]
        public string Mobile { get; set; }

        [Column(TypeName = "varchar(20)")]
        [Required]
        public string Email { get; set; }

        [Required]
        public int ServiceId { get; set; }

        [Required]
        public virtual Service service { get; set; }

        [Required]
        public int AreaId { get; set; }

        [Required]
        public virtual Area area { get; set; }

        [Required]
        public int CustomerId { get; set; }

        [Required]
        public virtual Customer Customer { get; set; }
    }
}
