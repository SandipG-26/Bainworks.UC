using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Brainworks.UC.Data
{
    public class Area
    {
        public int Id { get; set; }

        [Column(TypeName = "varchar(6)")]
        [Required]
        public string Pin { get; set; }

        [Column(TypeName = "varchar(20)")]
        [Required]
        public string City { get; set; }

        [Column(TypeName = "varchar(20)")]
        [Required]
        public string State { get; set; }

        [Column(TypeName = "varchar(20)")]
        [Required]
        public string Subarea { get; set; }

        public List<Vendor> vendor { get; set; }
        public List<Customer> customer { get; set; }

    }
}
