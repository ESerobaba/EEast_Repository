using BusinessLogic.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Repository
{
    public class FakeData : ICustomerRepository
    {
        public FakeData()
        {
        }

        public IEnumerable<Customer> GetAllCustomer()
        {
            Customer cust1 = new Customer()
            {
                CustomerId = 1,
                FirstName = "Alex",
                LastName = "QWE",
                OtherName = "ER",
                PhoneNumber = "123"
            };
            Customer cust2 = new Customer()
            {
                CustomerId = 1,
                FirstName = "Rtsdf",
                LastName = "QWE",
                OtherName = "ER",
                PhoneNumber = "345"
            };
            List<Customer> list = new List<Customer>();
            list.Add(cust1);
            list.Add(cust2);
            return list;
        }
    }
}
