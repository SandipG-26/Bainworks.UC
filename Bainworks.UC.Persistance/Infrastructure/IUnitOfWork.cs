using Brainworks.UC.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Brainworks.UC.Persistance
{
    public interface IUnitOfWork : IDisposable
    {
        Repository<Customer> CustomerRepository { get;  }
        Repository<Vendor> VendorRepository { get; }
        Repository<Area> AreaRepository { get; }
        Repository<Service> ServiceRepository { get; }
        int Save();
         
    }
}
