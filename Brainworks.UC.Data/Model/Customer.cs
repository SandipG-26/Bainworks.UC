using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Brainworks.UC.Data
{
    public class Customer
    {
        public int Id { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Required]
        public string FirstName { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Required]
        public string LastName { get; set; }

        [Column(TypeName = "varchar(100)")]
        [Required]
        public string Address { get; set; }

        [Column(TypeName = "varchar(200)")]
        [Required]
        public string Landmark { get; set; }

        [Column(TypeName = "varchar(100)")]
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

        [Column(TypeName = "varchar(30)")]
        [Required]
        public string Email { get; set; }

        [Required]
        public int ServiceId { get; set; }

        [Required]
        public  virtual Service service { get; set; }

        [Required]    
        public int AreaId { get; set; }

        [Required]
        public virtual Area area { get; set; }


        public virtual List<Vendor> vendor { get; set; }
        public virtual List<Assign> assign { get; set; }
        public virtual List<Completed> completed { get; set; }
        public virtual List<NewLead> newLead { get; set; }
        public virtual List<Replacement> replacement { get; set; }
        public virtual List<Complaint> complaint { get; set; }

    }
}
