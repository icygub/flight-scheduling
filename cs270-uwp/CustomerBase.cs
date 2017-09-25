using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs270_uwp
{
    public class CustomerBase
    {
        List<Customer> customers = new List<Customer>();
        public void addCustomer(String customer)
        {
            customers.Add(new Customer("John"));
        }

        public bool findCustomer(String customer)
        {
            foreach (Customer c in customers)
            {
                if (c.Name.Equals(customer))
                {
                    return true;
                 
                }
            }
            return false;
        }

        public void deleteCustomer(String customer) {
            
        }

        public void editCustomer(String customer, String editedCustomer) { }
    }
}

