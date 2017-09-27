using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs270_uwp {
    public class CustomerBase {
        List<Customer> customers = new List<Customer>();

        public void addCustomer(Customer customer) {
            bool added = true;
            //check for duplicate customer id, which is not allowed
            foreach (Customer c in customers) {
                if (customer.Id == c.Id) {
                    //duplicate found
                    System.Diagnostics.Debug.WriteLine("Customer " + customer.Id + " NOT added.");
                    added = false;
                    break;
                }
            }
            if (added) {
                System.Diagnostics.Debug.WriteLine("Customer " + customer.Id + " added.");
                customers.Add(new Customer(customer.Name, customer.Id));
            }
        }

        public Customer findCustomer(int id) {
                if (customers.Count == 0) {
                    System.Diagnostics.Debug.WriteLine("There are no customers.");
                    return null;
                }
                foreach (Customer c in customers) {
                    if (c.Id == id) {
                        return c;
                    }
                }
                System.Diagnostics.Debug.WriteLine("Customer " + id + " not found");
                return null;
        }

        public void deleteCustomer(Customer customer) {
            bool customerFound = false;
            //check if the customer exists
            foreach (Customer c in customers) {
                if (c.Id == customer.Id) {
                    customers.Remove(customer);
                    System.Diagnostics.Debug.WriteLine("Customer " + customer.Id + " was found and removed.");
                    customerFound = true;
                    break;
                }
            }
            if (!customerFound) {
                System.Diagnostics.Debug.WriteLine("Customer " + customer.Id + " was NOT found and NOT removed.");
            }
        }

        public Customer editCustomer(Customer customer, String nameEdits) {
            if(customers.Count == 0) {
                System.Diagnostics.Debug.WriteLine("There are no customers.");
                return null;
            }
            //customer found
            else if(findCustomer(customer.Id) == null) {
                customer.Name = nameEdits;
                return customer;
            }
            else {
                System.Diagnostics.Debug.WriteLine("Customer " + customer.Id + " was NOT found and NOT edited.");
                return null;
            }
        }
    }
}

