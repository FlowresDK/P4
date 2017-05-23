using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace IGEN_Storage_system_v2
{
    public class Giver
    {

        public int GiverID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PhoneNumber { get; set; }
        public string Mail { get; set; }
        public string StreetName { get; set; }
        public string CityName { get; set; }
        public int ZipCode { get; set; }
        public DateTime PickUpDate { get; set; }
        public DateTime PickUpTime { get; set; }
        public string PickUpComment { get; set; }

        public Giver()
        {

        }

        public Giver(int giverID, string firstName, string lastName, int phoneNumber, string mail, string streetName, string cityName, int zipCode, DateTime pickUpDate, DateTime pickUpTime, string pickUpComment)
        {

            GiverID = giverID;
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Mail = mail;
            StreetName = streetName;
            CityName = cityName;
            ZipCode = zipCode;
            PickUpDate = pickUpDate;
            PickUpTime = pickUpTime;
            PickUpComment = pickUpComment;
        }
    }
}
