using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Brainworks.UC.Data
{
    public class About
    {
        public int Id { get; set; }

        [Column(TypeName = "varchar(500)")]
        [Required]
        public string SatisfactoryCustomer { get; set; }

        [Column(TypeName = "varchar(500)")]
        [Required]
        public string Goal { get; set; }

        [Column(TypeName = "varchar(500)")]
        [Required]
        public string Ahievement { get; set; }
    }
}
