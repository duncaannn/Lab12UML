using System;
using System.Collections.Generic;
using System.Text;

namespace Lab12UML
{
    class Staff : Person
    {
        private string school;
        private double pay;

        public string School { get; set; }
        public double Pay { get; set; }

        public Staff() { }//default constructor
        public Staff(string Name, string Address, string School, double Pay)
            :base(Name, Address)
        {
            this.School = School;
            this.Pay = Pay;
        }

        public override string PrintNameAddress()
        {
            return base.PrintNameAddress() + School + Pay;
        }
    }
}
