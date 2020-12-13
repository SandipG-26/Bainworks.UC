using Brainworks.UC.Data;
using System;
using System.Collections.Generic;
using System.Text;
namespace Brainworks.UC.ViewModel
{
    public class ServiceViewModel
    {
        public int Id { get; set; }

        public string ServiceType { get; set; }

        public string ServiceSubType { get; set; }

        public string ServicePolicy { get; set; }

        public string warranty { get; set; }

        public string vendor { get; set; }
        public string assign { get; set; }
        public string completed { get; set; }
    }
}
