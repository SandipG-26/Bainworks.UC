using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Brainworks.UC.Data
{
    public class Assign
    {
        public int Id { get; set; }

        [Required]
        public int CustomerId { get; set; }

        [Column(TypeName = "varchar(20)")]
        [Required]
        public string City { get; set; }

        [Required]
        public int StatusId { get; set; }

        [Required]
        public int PinId { get; set; }

        [Required]
        public int ServiceId { get; set; }

        [Required]
        public virtual Service service { get; set; }

        [Required]
        public virtual Customer customer { get; set; }
        public virtual List<Replacement> replacement { get; set; }
        public virtual List<NewLead> newlead { get; set; }
        public virtual List<Complaint> complaint { get; set; }
        public virtual List<Completed> comleted { get; set; }
    }
}
