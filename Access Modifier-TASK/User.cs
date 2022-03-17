using System;
using System.Collections.Generic;
using System.Text;

namespace Access_Modifier_TASK
{
    internal class User
    {
        protected string _username=Console.ReadLine();
        protected string _password = Console.ReadLine();
        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                if (value.Length > 6)
                {
                    _username = value;
                }
                else
                {
                    Console.WriteLine("Yeniden Usaname'nizi daxil edin ");
                }
            }
        }
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {

                if (value.Length > 1 && value.Contains("A"))
                {
                    value = _password;
                }
                else
                {
                    Console.WriteLine("Yeniden Password'unuzu daxil edin");
                }
            }
        }
        public User(string username,string password)
        {
           Username = username;
            Password = password;
        }
    }
}
