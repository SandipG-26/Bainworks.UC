using System.ComponentModel.DataAnnotations;

namespace Brainworks.UC.Data
{
    public class Complaint
    {
        public int Id { get; set; }

        [Required]
        public int CustomerId { get; set; }

        [Required]
        public int CityId { get; set; }

        [Required]
        public int StatusId { get; set; }

        [Required]
        public virtual Customer customer { get; set; }

        [Required]
        public virtual Assign assign { get; set; }
    }
}
