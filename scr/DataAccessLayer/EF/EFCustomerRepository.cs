using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessLogic.Entities;
using BusinessLogic.Repository;
namespace DataAccessLayer.EF
{
    public class EFCustomerRepository : ICustomerRepository
    {
        private readonly Context context;
        public EFCustomerRepository(Context context)
        {
            if (context == null) throw new ArgumentNullException("context");
            this.context = context;
        }
        public IEnumerable<Customer> GetAllCustomer()
        {
            var customer = context.Customers.OrderBy(x=>x.CustomerId).ToArray();
            return customer;
        }
    }
}
