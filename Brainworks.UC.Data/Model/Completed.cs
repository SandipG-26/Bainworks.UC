using System.ComponentModel.DataAnnotations;

namespace Brainworks.UC.Data
{
    public class Completed
    {
        public int Id { get; set; }

        [Required]
        public int CustomerId { get; set; }

        [Required]
        public int CityId { get; set; }

        [Required]
        public int StatusId { get; set; }

        [Required]
        public int CustPinId { get; set; }

        [Required]
        public int ServiceId { get; set; }
        
        [Required]
        public virtual Service service { get; set; }

        [Required]
        public virtual Customer customer { get; set; }
       
        [Required]
        public virtual Assign assign { get; set; }

    }
}
