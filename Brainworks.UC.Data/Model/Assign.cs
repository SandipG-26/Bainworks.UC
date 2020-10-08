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
        public string StatusId { get; set; }
        public Completed completed { get; set; }
        public int CustPinId { get; set; }
        public int ServiceId { get; set; }
        public Service service { get; set; }
        public Customer customer { get; set; }
        public List<Replacement> replacement { get; set; }
        public List<NewLead> newlead { get; set; }
        public List<Complaint> complaint { get; set; }

    }
}
