using Brainworks.UC.Data;
using Brainworks.UC.ViewModel;
using System.Collections.Generic;


namespace Brainworks.UC.Services
{
    public interface IServiceServices 
    {
        IEnumerable<ServiceViewModel> GetAllServices();
        Service GetById(int Id);
        Service GetByServieType(string ServiceType);
        int AddServices(Service service);

        ServiceViewModel AddService(ServiceViewModel service); 
       
    }
}
