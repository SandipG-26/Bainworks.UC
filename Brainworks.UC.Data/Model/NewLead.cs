using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Brainworks.UC.Data
{
    public class NewLead
    {
        public int Id { get; set; }

        [Column(TypeName = "varchar(20)")]
        [Required]
        public int CustomerId { get; set; }

        [Required]
        public string CityId { get; set; }

        [Required]
        public int CustPinId { get; set; }

        [required]
        public virtual Customer customer { get; set; }

        [required]
        public virtual Assign assign { get; set; }
    }
}
