using System;
using System.Collections.Generic;

namespace Lab12UML
{
    class Program
    {
        static void Main(string[] args)
        {
            Student CrazyLegsJimmy = new Student("Crazy Legs Jimmy" , " 453 West Bromward, Seattle, Washington" , " Fine Arts ", 56,700);
            Student Morty = new Student("Morty", " 63453 North Main, Yorkshire Ave, Cleveland, Ohio ", "Sports Science ", 78,456);
            Student Mugatu = new Student("Mugatu", "  Address Unknown", "High Fashion ", 99,657);
            Staff RickSanchez = new Staff("Rick Sanchez", " 232 Kepler B ", "Chemistry ", 56777);
            Staff BrianEno = new Staff("Brian Eno", " 234 Scheinstrasse, Berlin, Germany ", " Experimental Music Theory ", 55000);

            Morty.PrintNameAddress();
            BrianEno.PrintNameAddress();
            

            List<Person> Roster = new List<Person>
          {
              CrazyLegsJimmy, Morty, Mugatu, RickSanchez, BrianEno
          };
            foreach (Person person in Roster)
            Console.WriteLine(person.PrintNameAddress());
               // person.PrintNameAddress();
            
        }

    }
}

