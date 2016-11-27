using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_storage.DataManager
{
    public class LoginFormular : ICloneable
    {
        private string website = "";
        private string email = "";
        private string username = "";
        private string password = "";
        private string firstName = "";
        private string lastName = "";

        public bool IsEmpty()
        {
            if (website + email + username + password + firstName + lastName == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Website
        {
            get { return website; }
            set { website = value; }
        }

        public string EMail
        {
            get { return email; }
            set { email = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

    }
}
