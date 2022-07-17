namespace Day9AddressBook
{
    class Contact
    {
        private string firstName;
        private string lastName;
        private string address;
        private string city;
        private string state;
        private int zip;
        private long phoneNumber;
        private string email;
        

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