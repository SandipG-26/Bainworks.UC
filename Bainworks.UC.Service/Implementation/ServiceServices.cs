using Brainworks.UC.Data;
using System.Collections.Generic;
using Brainworks.UC.Persistance;
using Brainworks.UC.ViewModel;
using AutoMapper;

namespace Brainworks.UC.Services
{
    public class ServiceServices : IServiceServices
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public ServiceServices(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this._mapper = mapper;
            this._unitOfWork = unitOfWork;
        }
        public IEnumerable<ServiceViewModel> GetAllServices()
        {
            var servicelist =  this._unitOfWork.ServiceRepository.GetAll();
            var serviceviewmodellists = this._mapper.Map<IEnumerable<ServiceViewModel>>(servicelist);
            return serviceviewmodellists;
        }
        public ServiceViewModel AddService(ServiceViewModel service)
        {
            Service newService = _mapper.Map<Service>(service);
            this._unitOfWork.ServiceRepository.Add(newService);
            _ = this._unitOfWork.Save;
            return this._mapper.Map<ServiceViewModel>(newService);

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
            _ = this._unitOfWork.Save;
            return service.Id;

            //context.customers.Add(customer);
            //context.SaveChanges();
        }
    }
}
