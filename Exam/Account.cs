using System;
using System.Collections.Generic;
using System.Text;

namespace Exam
{
    class Account
    {
        private string _name;
        private string _surname;
        public string PhoneNumber { get; private set; }
        public int Age { get; private set; }
        private double _sum;
        
        public string Name
        {

            get { return _name; }
            private set
            {
                value = value.Trim();
                _name = value[0].ToString().ToUpper() + value.Substring(1);
            }
        }
        public string Surname
        {
            get { return _surname; }
            private set
            {
                value = value.Trim();
                _surname = value[0].ToString().ToUpper() + value.Substring(1);

            }
        }

        public Account(string name, string surname, string phone, int age)
        {
            Name = name;
            Surname = surname;
            PhoneNumber = phone;
            Age = age;
        }
        
    }
}
