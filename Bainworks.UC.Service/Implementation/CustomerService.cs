using Brainworks.UC.Data;
using System.Collections.Generic;
using Brainworks.UC.Persistance;

namespace Brainworks.UC.Services
{
    public class CustomerService : ICustomerService
    {
        //CRUD
        private readonly IUnitOfWork _unitOfWork;
        public CustomerService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }
        public IEnumerable<Customer> GetAllCustomers()
        {
            return this._unitOfWork.CustomerRepository.GetAll();

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
            this._unitOfWork.Save();
            return customer;

            //context.customers.Add(customer);
            //context.SaveChanges();
        }
        public Customer UpdateCustomers(Customer customer)
        {
            this._unitOfWork.CustomerRepository.update(customer);
            this._unitOfWork.Save();
            return customer;
        }
    }
}
