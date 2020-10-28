using Brainworks.UC.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Brainworks.UC.Services
{
    public interface ICustomerService
    {
        IEnumerable<Customer> GetAllCustomers();
        Customer GetById(int Id);
        Customer GetByEmail(string Email);
        Customer AddCustomers(Customer customer);
        Customer UpdateCustomers(Customer customer);
    }
}
