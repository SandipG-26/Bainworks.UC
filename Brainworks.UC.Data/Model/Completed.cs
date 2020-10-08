using System;
using System.Collections.Generic;
using System.Text;

namespace Brainworks.UC.Data
{
    public class Completed
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int CityId { get; set; }
        public int StatusId { get; set; }
        public int CustPinId { get; set; }
        public int ServiceId { get; set; }
        public Service service { get; set; }
        public Customer customer { get; set; }
        public Assign assign { get; set; }

    }
}
