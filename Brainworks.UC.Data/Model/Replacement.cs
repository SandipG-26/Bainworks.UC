using System;
using System.Collections.Generic;
using System.Text;

namespace Brainworks.UC.Data
{
    public class Replacement
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string CityId { get; set; }
        public string StatusId { get; set; }
        public Customer customer { get; set; }
        public Assign assign { get; set; }

    }
}