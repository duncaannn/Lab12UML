using System;
using System.Collections.Generic;
using System.Text;

namespace Lab12UML
{
    class Person
    {
        private string name;
        private string address;

        public string Name { get; set; }
        public string Address { get; set; }
      
        public Person() { } //default constructor
        public Person(string Name, string Address)
        {
            this.Name = Name;
            this.Address = Address;
        }
        public virtual string PrintNameAddress()
        {
            return  Name + Address;
           
        }

    }
}
