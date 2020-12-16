using System;
using System.Collections.Generic;
using System.Text;

namespace DapperForm
{
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAdress { get; set; }
        public string PhoneNumber { get; set; }

        public string FullInfo
        {
            get 
            { 
              
                return $"{FirstName}, {LastName}, ({EmailAdress})"; 
            }
           
        }

    }
}
