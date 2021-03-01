using System;

namespace ClassMetotDemo
{
    public class Customer
    {
        private static int _id = 0;
        private string _firstName;
        private string _lastName;
        private string _address;
        private string _phone;

        public int Id { get; }
        public string FirstName { get { return _firstName; } set { _firstName = value; } }
        public string LastName { get { return _lastName; } set { _lastName = value; } }
        public string Address { get { return _address; } set { _address = value; } }
        public string Phone { get { return _phone; } set { _phone = value; } }

        public Customer()
        {
            Id = _id;
            _id += 1;
        }

        public void Update(string Message)
        {
            Console.WriteLine("Mesaj alındı: " + Message);
        }
    }
}