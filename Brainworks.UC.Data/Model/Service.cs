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
        public List<Customer> customers { get; set; }
        public List<Vendor> vendors { get; set; }

    }
} 
