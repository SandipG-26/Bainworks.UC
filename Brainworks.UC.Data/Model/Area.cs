using System;
using System.Collections.Generic;
using System.Text;

namespace Brainworks.UC.Data
{
    public class Area
    {
        public int Id { get; set; }
        public string Pin { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Subarea { get; set; }
        public List<Vendor> vendor { get; set; }
        public List<Customer> customer { get; set; }

    }
}
