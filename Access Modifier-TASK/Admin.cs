using System;
using System.Collections.Generic;
using System.Text;

namespace Access_Modifier_TASK
{
    internal class Admin:User
    {
        public bool isSuperAdmin;
        public string Section;


        public Admin(bool isSuperadmin, string section, string password, string username):base(username, password)          
        {
           isSuperAdmin = isSuperadmin;
            Section = section;           
        }
        public void getInfo()
        {
            if (_password == Password && _username == Username)
            {
                Console.WriteLine($"Username: {_username}, Password: {_username}");
            }
        }
    }
}
