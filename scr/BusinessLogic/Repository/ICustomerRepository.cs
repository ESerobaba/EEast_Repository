using BusinessLogic.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Repository
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> GetAllCustomer();
    }
}
