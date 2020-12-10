using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Brainworks.UC.Data
{
    public class FirstPage
    {
        public int Id { get; set; }

        [Column(TypeName = "varchar(100)")]
        [Required]
        public string Reference { get; set; }

        [Column(TypeName = "varchar(20)")]
        [Required]
        public string Key { get; set; }

        [Column(TypeName = "varchar(500)")]
        [Required]
        public string Value { get; set; }
    }
}
