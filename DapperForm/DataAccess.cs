using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace DapperForm
{
    class DataAccess
    {
        public List<Person> GetPeople(string lastName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SampleDb")))
            {
                //var output = connection.Query<Person>($"select * from People where LastName = '{lastName}' ").ToList(); not recommended 
                var output = connection.Query<Person>("dbo.People_GetByLastName @LastName", new { LastName = lastName }).ToList();
                return output;
            }
            
        }

        public void InsertPerson(string firstName, string lastName, string emailAdress, string phoneNumber)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SampleDb")))
            {
                // Person newPerson = new Person {FirstName = firstName, LastName = lastName, EmailAdress = emailAdress, PhoneNumber = phoneNumber };
                List<Person> people = new List<Person>();
                people.Add(new Person{FirstName = firstName, LastName = lastName, EmailAdress = emailAdress, PhoneNumber = phoneNumber});

                connection.Execute("dbo.People_Insert @FirstName, @LastName, @EmailAdress, @PhoneNumber", people);
            }
        }
    }
}
