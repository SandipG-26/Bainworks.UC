using System;
using System.Collections.Generic;
using System.Text;

namespace Brainworks.UC.Data
{
    public class Feedback
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public Customer customer { get; set; }
        public int VendorId { get; set; }
        public Vendor vendor { get; set; }
        public string Comment { get; set; }
    }
}
