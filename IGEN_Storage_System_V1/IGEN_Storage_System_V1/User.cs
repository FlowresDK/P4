using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGEN_Storage_System_V1
{
    class User
    {
        public int UserID {get; set;} 
        public string FirstName {get; set;} 
        public string LastName {get; set;} 
        public int PhoneNumber {get; set}
        public string Mail {get; set}
        public string SteetName {get; set;} 
        public string CityName {get; set;} 
        public int ZipCode{get; set;} 
        public int Role {get;set;}
        public int Rights {get;set;}
        
        public User()
        {
        }


        public void CreateUser()
        {
        }

        public void DeleteUser()
        {
        }

        public void SearchUser()
        {
        }
 
        public void EditUser()
        {
        }

        public void ListUser()
        {
        }
    }
}
