﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Brainworks.UC.Data
{
    public class Billing
    {
        public int Id { get; set; }
        public string ServiceCharge { get; set; }
        public decimal MaterialCharge { get; set; }
        public decimal  Total{ get; set; }
        public decimal GST { get; set; }
        public List<Due> due { get; set; }
    }
}