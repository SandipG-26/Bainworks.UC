using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Brainworks.UC.Data
{
    public class Billing
    {
        public int Id { get; set; }

        [Column(TypeName = "varchar(20)")]
        [Required]
        public string ServiceCharge { get; set; }

        [Column(TypeName = "varchar(20)")]
        [Required]
        public decimal MaterialCharge { get; set; }

        [Column(TypeName = "varchar(20)")]
        [Required]
        public decimal Total { get; set; }

        [Column(TypeName = "varchar(20)")]
        [Required]
        public decimal GST { get; set; }

        public List<Due> due { get; set; }
    }
}
