using Brainworks.UC.Data;
using System.Collections.Generic;
using Brainworks.UC.Persistance;
using Brainworks.UC.ViewModel;
using AutoMapper;

namespace Brainworks.UC.Services
{
    public class CustomerService : ICustomerService
    {
        //CRUD
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public CustomerService(IMapper mapper, IUnitOfWork unitOfWork)
        {
           this._mapper = mapper;
           this._unitOfWork = unitOfWork;
        }
        public IEnumerable<CustomerViewModel> GetAllCustomers()
        {
            var customerlist =  this._unitOfWork.CustomerRepository.GetAll();
            var customerViewModellist = _mapper.Map<IEnumerable<CustomerViewModel>>(customerlist);
            return customerViewModellist;
        }
        public Customer GetById(int Id)
        {
            return this._unitOfWork.CustomerRepository.GetById(Id);

        }
        public Customer GetByEmail(string Email)
        {
            return this._unitOfWork.CustomerRepository.FirstOrDefault(x => x.Email == Email);
        }
        public Customer AddCustomers(Customer customer)
        {
            this._unitOfWork.CustomerRepository.Add(customer);
            this._unitOfWork.Save;
            return customer;

            //context.customers.Add(customer);
            //context.SaveChanges();
        }
        public Customer UpdateCustomers(Customer customer)
        {
            this._unitOfWork.CustomerRepository.update(customer);
            this._unitOfWork.Save;
            return customer;
        }
        public bool DeleteCustomers(int customerId)
        {
            Customer customer = this._unitOfWork.CustomerRepository.GetById(customerId);

            if (customer != null)
            {
                this._unitOfWork.CustomerRepository.remove(customer);
                this._unitOfWork.Save;
                return true;
            }
            return false;
        }
    }
}
