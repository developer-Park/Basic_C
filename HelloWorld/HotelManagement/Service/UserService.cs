using HotelManagement.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Service
{
    internal class UserService
    {


        List<User> users;

        public UserService()
        {
            this.users = new List<User>();
        }



        public void addUser(String username, String password)
        {
            User user = new User(username, password);
            users.Add(user);
            Console.WriteLine("Success add entity.Customer. Thanks.");

        }

        public void getUserInfo(User user)
        {
            Console.WriteLine("Username : " + user.getUserName());
            Console.WriteLine("password : " + user.getPassword());
        }
        public String getUsername()
        {
            foreach (User user in users)
            {
                return user.getUserName();
            }
            throw new Exception("User is not exist.");
        }

        public User Login(String username, String password)
        {
            foreach (User user in users)
            {
                if (user.getUserName() == username && user.getPassword() == password)
                {
                    return user;
                }
            }
            throw new Exception("Wrong ID or Password");
        }
    }
}
