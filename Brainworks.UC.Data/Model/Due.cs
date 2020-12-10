using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Brainworks.UC.Data
{
    public class Due
    {
        public int Id { get; set; }

        [Required]
        public int ServiceChargeId { get; set; }

        [Required]
        public int MaterialChargeId { get; set; }

        [Required]
        public int TotalId { get; set; }

        [Required]
        public virtual Billing billing { get; set; }

    }
}
