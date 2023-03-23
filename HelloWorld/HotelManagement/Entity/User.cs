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

        public User(String userName, String password, int customerMoney)
        {
            this.userName = userName;
            this.password = password;
            this.customerMoney = customerMoney;

        }
    }
}
