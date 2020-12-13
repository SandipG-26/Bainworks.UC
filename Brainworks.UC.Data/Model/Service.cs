using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Brainworks.UC.Data
{
    public class Service
    {
        public int Id { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Required]
        public string ServiceType { get; set; }

        [Column(TypeName = "varchar(100)")]
        [Required]
        public string ServiceSubType { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Required]
        public string ServicePolicy { get; set; }

        [Column(TypeName = "varchar(10)")]
        [Required]
        public string warranty { get; set; }

        public virtual List<Customer> customer { get; set; }
        public virtual List<Vendor> vendor { get; set; }
        public virtual List<Assign> assign { get; set; }
        public virtual List<Completed> completed { get; set; }

    }
}
