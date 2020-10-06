using System;
using System.Collections.Generic;
using System.Text;

namespace Brainworks.UC.Data
{
    public class Vendor
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string ShopName { get; set; }
        public string Address { get; set; }
        public string Landmark { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Pin { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public int ServiceId { get; set; }
        public Service service { get; set; }
        public int AreaId { get; set; }
        public Area area { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
