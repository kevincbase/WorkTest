using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp.Models;

namespace TestApp.ViewModels
{
    public class CustomerViewModel
    {
        public List<Customer> Customers { get; set; }
        public Customer SelectedCustomer { get; set; }

        public CustomerViewModel()
        {
            Init();
            
        }
        public void Init()
        {
            Customers = new List<Customer>();
            for (var x = 1; x < 10; x++)
            {
                Customer item = new Customer
                {
                    FName = "Fname" + x,
                    LName = "Lname" + x,
                    Id = x
                };
                Customers.Add(item);
            }
        }
    }
}
