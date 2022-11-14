using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreOPG
{
    public class CustomerAdmin
    {
        List<Customer> customers = new List<Customer>();

        public void AddCustomer(Customer c1)
        {
            customers.Add(customers[3]);
        }

        public void DeleteCustomer(Customer c1)
        {
            customers.Remove(customers[3]);
        }

        public void SearchCustomer(Customer c1)
        {
            customers.Add(c1 as Customer);
        }

        public void UpdateCustomer(int id, string name, object NewName)
        {
            foreach (var item in customers)
            {
                if (item.Key == name)
                {
                    customers[id].customers = NewName;
                }
            }
        }

        internal void UpdateCustomer(Customer c3, string v1, string v2)
        {
            throw new NotImplementedException();
        }
    }
}
