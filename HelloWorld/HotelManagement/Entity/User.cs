using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Entity
{
    internal class User
    {
        String userName { get; }
        String password { get; }
        int customerMoney { get; }

      


        public User(String userName, String password)
        {
            this.userName = userName;
            this.password = password;
            this.customerMoney = 10000;

        }

        public string getUserName() { return userName; }
        public string getPassword() { return password; }
        public int getCustomerMoney()
        {
            return customerMoney;
        }
    }
}
