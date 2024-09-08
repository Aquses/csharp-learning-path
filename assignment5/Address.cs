using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assingment5
{
    internal class Address
    {
        private string city;
        private Countries country;
        private string street;
        private string zipCode;

        /// <summary>
        /// Default constructor initializes with empty strings and default country.
        /// </summary>
        public Address() : this("", "", "", Countries.Sweden) { }

        /// <summary>
        /// Copy constructor initializes with another Address object's details.
        /// </summary>
        /// <param name="theOther"></param>
        public Address(Address theOther) : this(theOther.street, theOther.city, theOther.zipCode, theOther.country) { }

        /// <summary>
        /// Constructor initializes with provided street, city, zip code, and country.
        /// </summary>
        /// <param name="street"></param>
        /// <param name="city"></param>
        /// <param name="zipCode"></param>
        /// <param name="country"></param>
        public Address(string street, string city, string zipCode, Countries country)
        {
            this.street = street;
            this.city = city;
            this.zipCode = zipCode;
            this.country = country;
        }

        /// <summary>
        /// Constructor initializes with provided street, city, and zip code, defaulting to Sweden as country.
        /// </summary>
        /// <param name="street"></param>
        /// <param name="city"></param>
        /// <param name="zip"></param>
        public Address(string street, string city, string zip) : this(street, city, zip, Countries.Sweden) { }

        /// <summary>
        /// Property to get or set the street.
        /// </summary>
        public string Street
        {
            get { return street; }
            set { if (!string.IsNullOrEmpty(value)) street = value; }
        }

        /// <summary>
        /// Property to get or set the city.
        /// </summary>
        public string City
        {
            get { return city; }
            set { if (!string.IsNullOrEmpty(value)) city = value; }
        }

        /// <summary>
        /// Property to get or set the zip code.
        /// </summary>
        public string ZipCode
        {
            get { return zipCode; }
            set { if (!string.IsNullOrEmpty(value)) zipCode = value; }
        }

        /// <summary>
        /// Property to get or set the country.
        /// </summary>
        public Countries Country
        {
            get { return country; }
            set { country = value; }
        }

        /// <summary>
        /// Method to get the address label formatted as "Street and ZipCode City".
        /// </summary>
        /// <returns></returns>
        public string GetAddressLabel()
        {
            return $"{Street}\n{ZipCode} {City}";
        }

        /// <summary>
        /// Method to get the country as a string with underscores replaced by spaces.
        /// </summary>
        /// <returns></returns>
        public string GetCountryString()
        {
            return country.ToString().Replace("_", " ");
        }

        /// <summary>
        /// Override of ToString method to return address details as a formatted string.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("{0, -25} {1, -8} {2, -10} {3, 1}", street, zipCode, city, GetCountryString());
        }

        /// <summary>
        /// Method to validate the address details.
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            return !string.IsNullOrEmpty(Street) && !string.IsNullOrEmpty(City) && !string.IsNullOrEmpty(ZipCode);
        }
    }
}