using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assingment5
{
    internal class Participant
    {
        private Address address;
        private string firstName;
        private string lastName;

        /// <summary>
        /// Constructor to initialize the Participant with first name, last name, and address.
        /// </summary>
        public Participant(string firstName, string lastName, Address adr)
        {
            this.firstName = firstName;
            this.lastName = lastName;

            if (adr != null)
            {
                address = adr;
            }
            else
            {
                address = new Address();
            }
        }

        /// <summary>
        /// Copy constructor to initialize the Participant with another Participant's details.
        /// </summary>
        /// <param name="theOther"></param>
        public Participant(Participant theOther) : this(theOther.FirstName, theOther.SecondName, new Address(theOther.Address)) { }

        /// <summary>
        /// Default constructor to initialize the Participant with default values.
        /// </summary>
        public Participant() : this("", "", new Address()) { }

        /// <summary>
        /// Property to get or set the address.
        /// </summary>
        public Address Address { 

            get { return address; } 
            set { address = value; } 
        }

        /// <summary>
        /// Property to get or set the first name.
        /// </summary>
        public string FirstName { 
            get { return firstName; } 
            set { firstName = value; } 
        }

        /// <summary>
        /// Property to get or set the last name (renamed to SecondName for consistency).
        /// </summary>
        public string SecondName
        {
            get { return lastName; }
            set { lastName = value; }   
        }

        /// <summary>
        /// Property to get the full name in the string format "LastName, FirstName".
        /// </summary>
        public string fullName => $"{SecondName}, {FirstName}";

        /// <summary>
        /// Override of the ToString method to return participant details as a formatted string.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("{0,-20} {1}", fullName, address.ToString());
        }

        /// <summary>
        /// Method to validate the participant details.
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            return address.Validate() && !string.IsNullOrEmpty(FirstName) && !string.IsNullOrEmpty(SecondName);
        }
    }
}
