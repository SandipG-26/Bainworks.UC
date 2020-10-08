using System;
using System.Collections.Generic;
using System.Text;

namespace Brainworks.UC.Data
{
    public class Assign
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string City { get; set; }
        public int Pin { get; set; }
        public int ServiceId { get; set; }
        public Service service { get; set; }
        public Customer customer { get; set; }
    }
}
