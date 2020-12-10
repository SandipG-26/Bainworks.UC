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

        public List<Customer> customer { get; set; }
        public List<Vendor> vendor { get; set; }
        public List<Assign> assign { get; set; }
        public List<Completed> completed { get; set; }

    }
}
