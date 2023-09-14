using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace H1_TheQueue.Model
{
    /// <summary>
    /// Class <see cref="Person"/> represents a Person using important information about that Person
    /// </summary>
    internal class Person
    {
        private string _firstName;
        private string _lastName;
        private string _phoneNumber;
        private string _email;

        /// <summary>
        /// Initializes a new instance of the <see cref="Person"/> class, using information about that Person
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="email"></param>
        public Person(string firstName, string lastName, string phoneNumber, string email)
        {
            _firstName = firstName;
            _lastName = lastName;
            _phoneNumber = phoneNumber;
            _email = email;
        }

        public string FirstName
        {
            get { return _firstName; }
        }

        public string LastName
        {
            get { return _lastName; }
        }
    }
}
