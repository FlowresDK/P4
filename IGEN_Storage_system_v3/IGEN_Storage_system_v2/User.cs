using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGEN_Storage_system_v2
{
    public class User
    {

        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PhoneNumber { get; set; }
        public string Mail { get; set; }
        public string StreetName { get; set; }
        public string CityName { get; set; }
        public int ZipCode { get; set; }
        public int Role { get; set; }
        public int Rights { get; set; }

        public User()
        {

        }

        public User(int userID, string firstName, string lastName, int phoneNumber, string mail, string streetName, string cityName, int zipCode, int role, int rights)

        {
            UserID = userID;
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Mail = mail;
            StreetName = streetName;
            ZipCode = zipCode;
            Role = role;
            Rights = rights;
        }
    }
}
