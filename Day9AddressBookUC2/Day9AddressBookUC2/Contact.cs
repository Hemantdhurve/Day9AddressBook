using System;
using System.Collections.Generic;
using System.Text;

namespace Day9AddressBook
{
    class Contact
    {
        /// Variables
        string firstName;
        string lastName;
        string address;
        string city;
        string state;
        int zip;
        long phoneNumber;
        string email;

        
        public Contact(string firstName, string lastName, string address, string city, string state, int zip, long phoneNumber, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.phoneNumber = phoneNumber;
            this.email = email;
        }

        override
        public string ToString()
        {
            return "FirstName : " + firstName + " LastName : " + lastName + " Address : " + address + " City : " + city + "State : " + state +
                " Zip Code :" + zip + " Phone Number : " + phoneNumber + " Email Id : " + email;
        }
    }
}