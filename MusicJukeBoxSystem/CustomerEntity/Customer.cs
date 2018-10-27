using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerEntity
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string CustName { get; set; }
        public string Address { get; set; }
        public DateTime DOB { get; set; }
        public string City { get; set; }
        public string Password { get; set; }
        public string MobileNo { get; set; }
    }
}
