using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Brainworks.UC.Data
{
    public class Replacement
    {
        public int Id { get; set; }

        [Column(TypeName = "varchar(20)")]
        [Required]
        public int CustomerId { get; set; }

        [Required]
        public int CityId { get; set; }

        [required]
        public int StatusId { get; set; }

        [required]
        public virtual Customer customer { get; set; }

        [required]
        public virtual Assign assign { get; set; }

    }
}