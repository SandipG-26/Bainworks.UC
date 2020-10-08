using System;
using System.Collections.Generic;
using System.Text;

namespace Brainworks.UC.Data
{
    public class Service
    {
        public int Id { get; set; }
        public string ServiceType { get; set; }
        public string ServiceSubType { get; set; }
        public string ServicePolicy { get; set; }
        public string warranty { get; set; }
        public List<Customer> customer { get; set; }
        public List<Vendor> vendor { get; set; }
        public List<Assign> assign { get; set; }

    }
} 
