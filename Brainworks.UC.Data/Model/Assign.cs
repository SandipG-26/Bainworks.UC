using System.Collections.Generic;

namespace Brainworks.UC.Data
{
    public class Assign
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string City { get; set; }
        public int StatusId { get; set; }
        public int PinId { get; set; }
        public int ServiceId { get; set; }
        public Service service { get; set; }
        public Customer customer { get; set; }
        public List<Replacement> replacement { get; set; }
        public List<NewLead> newlead { get; set; }
        public List<Complaint> complaint { get; set; }
        public List<Completed> comleted { get; set; }
    }
}
