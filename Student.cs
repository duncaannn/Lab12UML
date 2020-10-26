using System;
using System.Collections.Generic;
using System.Text;

namespace Lab12UML
{
    class Student : Person
    {
        private string program;
        private int year;
        private double fee;
        public string Program { get; set; }
        public int Year { get; set; }
        public double Fee { get; set; }

       
        public Student() { }


        public Student( string Name, string Address, string Program, int Year, double Fee)
            :base(Name, Address)
        {
            this.Program = Program;
            this.Year = Year;
            this.Fee = Fee;
        }
        public override string PrintNameAddress()
        {

            return base.PrintNameAddress() + Program + Year + Fee;
        }
    }
}
