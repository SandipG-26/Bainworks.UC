using Brainworks.UC.Data;
using Brainworks.UC.ViewModel;
using System.Collections.Generic;

namespace Brainworks.UC.Services
{
    public interface ICustomerService
    {
        IEnumerable<CustomerViewModel> GetAllCustomers();
        Customer GetById(int Id);
        Customer GetByEmail(string Email);
        Customer AddCustomers(Customer customer);
        Customer UpdateCustomers(Customer customer);
        bool DeleteCustomers(int customerId);

    }
}
