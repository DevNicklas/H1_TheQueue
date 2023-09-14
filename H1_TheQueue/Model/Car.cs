using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_TheQueue.Model
{
    /// <summary>
    /// Class <see cref="Car"/> represents a car with important information
    /// </summary>
    internal class Car
    {
        private string _licensePlate;
        private Person _owner;

        /// <summary>
        /// Initializes a new instance of the <see cref="Car"/> class, using multiple arguments
        /// </summary>
        /// <param name="licensePlate">plate which refers to that specific car</param>
        /// <param name="owner">owner of car</param>
        public Car(string licensePlate, Person owner)
        {
            _licensePlate = licensePlate;
            _owner = owner;
        }
        public string LicensePlate 
        { 
            get { return _licensePlate; } 
        }

        public Person Owner
        {
            get { return _owner; }
        }
    }
}
