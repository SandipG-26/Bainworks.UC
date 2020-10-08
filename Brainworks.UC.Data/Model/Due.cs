using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Brainworks.UC.Data
{
    public class Due
    {
        public int Id { get; set; }
        public int ServiceChargeId { get; set; }
        public int MaterialChargeId { get; set; }
        public int TotalId { get; set; }
        public Billing billing { get; set; }
       
    }
}
