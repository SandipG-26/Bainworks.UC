using Brainworks.UC.Data;
using System;
using System.Collections.Generic;
using System.Text;


namespace Brainworks.UC.Services
{
    public interface IServiceServices 
    {
        IEnumerable<Service> GetAllServices();
        Service GetById(int Id);
        Service GetByServieType(string ServiceType);
        int AddServices(Service service);
       
    }
}
