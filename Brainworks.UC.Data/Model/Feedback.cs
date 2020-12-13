using System.ComponentModel.DataAnnotations;

namespace Brainworks.UC.Data
{
    public class Feedback
    {
        public int Id { get; set; }

        [Required]
        public int CustomerId { get; set; }

        [Required]
        public virtual Customer customer { get; set; }

        [Required]
        public int VendorId { get; set; }

        [Required]
        public virtual Vendor vendor { get; set; }

        [Required]
        public string Comment { get; set; }
    }
}
