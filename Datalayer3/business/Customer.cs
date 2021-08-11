using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datalayer3.DataAcsess;

namespace Datalayer3.business
{
    public class Customer
    {
        public int CustomerID { set; get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }

        public void SaveCustomer(Customer cus)
        {
            CustomerIO.SaveRecord(cus);
        }
        public Customer AddRecord(int id)
        {
            return CustomerIO.AddRecord(id);
        }
    }
}



