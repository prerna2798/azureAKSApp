using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerMgmtProject.Models
{
    public class CustomerRepo:IRepo<Customer>
    {
        public List<Customer> customers { get; set; }

        public CustomerRepo()
        {
            customers = new List<Customer>()
            {
                new Customer
                {
                    Id=1,
                    Name="Tom",
                    Age=22
                }
            };
        }

        public void AddItem(Customer item)
        {
            customers.Add(item);
        }

        public IEnumerable<Customer> GetItems()
        {
            return customers;
        }
    }
}
