using Brainworks.UC.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Brainworks.UC.Persistance
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly UCcontext _context;
        public Repository<Customer> CustomerRepository { get; }
        public Repository<Vendor> VendorRepository { get; }
        public Repository<Area> AreaRepository { get; }
        public Repository<Service> ServiceRepository { get; }
        public UnitOfWork(UCcontext context)
        {
            this._context = context;
            this.CustomerRepository = new Repository<Customer>(this._context);
            this.VendorRepository = new Repository<Vendor>(this._context);
            this.AreaRepository = new Repository<Area>(this._context);
            this.ServiceRepository = new Repository<Service>(this._context);

        }
        public int Save()
        {
            return this._context.SaveChanges();
        }
        public void Dispose()
        {
            this._context.Dispose();    
        }

    }
}
