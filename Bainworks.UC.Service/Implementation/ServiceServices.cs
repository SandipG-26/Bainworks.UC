using Brainworks.UC.Data;
using System.Collections.Generic;
using Brainworks.UC.Persistance;


namespace Brainworks.UC.Services
{
    public class ServiceServices : IServiceServices
    {
        private readonly IUnitOfWork _unitOfWork;
        public ServiceServices(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }
        public IEnumerable<Service> GetAllServices()
        {
            return this._unitOfWork.ServiceRepository.GetAll();

        }
        public Service GetById(int Id)
        {
            return this._unitOfWork.ServiceRepository.GetById(Id);

        }
        public Service GetByServieType(string ServiceType)
        {
            return this._unitOfWork.ServiceRepository.FirstOrDefault(x => x.ServiceType == ServiceType);
        }
        public int AddServices(Service service)
        {
            this._unitOfWork.ServiceRepository.Add(service);
            this._unitOfWork.Save();
            return service.Id;

            //context.customers.Add(customer);
            //context.SaveChanges();
        }
    }
}
