﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf2
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string TelephoneNr { get; set; }

        public Person(string firstname, string lastname, int age, string phone)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Age = age;
            this.TelephoneNr = phone;
        }
    }
}
