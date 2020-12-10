using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Brainworks.UC.Data
{
    public class ContactUs
    {
        public int Id { get; set; }

        [Column(TypeName = "varchar(12)")]
        [Required]
        public string MobileNo { get; set; }

        [Column(TypeName = "varchar(20)")]
        [Required]
        public string Email { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Required]
        public string Address { get; set; }

    }
}
