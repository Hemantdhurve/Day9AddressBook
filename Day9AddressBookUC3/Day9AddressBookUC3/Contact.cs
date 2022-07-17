using System;
using System.Collections.Generic;
using System.Text;

namespace Day9AddressBook
{
    class Contact
    {
        /// Variables
        public string firstName;
        public string lastName;
        public string address;
        public string city;
        public string state;
        public long zipcode;
        public long phoneNumber;
        public string email;

        ///
        public Contact(string firstName, string lastName, string address, string city, string state, long zipcode, long phoneNumber, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zipcode = zipcode;
            this.phoneNumber = phoneNumber;
            this.email = email;
        }


        //Get and set methods are used
        //Whereas get method returns the value of the variable name

        public string GetFirstName()
        {
            return firstName;
        }

        public string GetLastName()
        {
            return lastName;
        }

        public string GetAddress()
        {
            return address;
        }

        public string GetCity()
        {
            return city;
        }
 
        public string GetState()
        {
            return state;
        }
  
        public string GetEmail()
        {
            return email;
        }
  
        public long GetPhoneNumber()
        {
            return phoneNumber;
        }

        public long GetZip()
        {
            return zipcode;
        }
   

        //Set method takes the parameter that is passed
        //and variable names are being assigned
        //Also this keyword is being used to refer the current object
        public void SetFirstName(string firstName)
        {
            this.firstName = firstName;
        }

        public void SetLastName(string lastName)
        {
            this.lastName = lastName;
        }
 
        public void SetAddress(string address)
        {
            this.address = address;
        }

        public void SetCity(string city)
        {
            this.city = city;
        }
 
        public void SetState(string state)
        {
            this.state = state;
        }

        public void SetZip(int zip)
        {
            this.zipcode = zipcode;
        }
        public void SetPhoneNumber(long phoneNumber)
        {
            this.phoneNumber = phoneNumber;
        }

        internal void SetPhoneNumber(string phoneNumber)
        {
            throw new NotImplementedException();
        }

        public void SetEmail(string email)
        {
            this.email = email;
        }

        internal void SetZipCode(string zipCode)
        {
            throw new NotImplementedException();
        }

        override
        public string ToString()
        {
            return "FirstName : " + firstName + " LastName : " + lastName + " Address : " + address + " City : " + city + "State : " + state +
                " Zip Code :" + zipcode + " Phone Number : " + phoneNumber + " Email Id : " + email;
        }
    }
}