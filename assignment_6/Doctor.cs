using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace assignment_6
{
    internal class Doctor:Person
    {
        public string Specialty { get; set; } 

        public new void Greet()
        {
            Console.WriteLine("I am a doctor.");
        }

        public override void Display()
        {
            Console.WriteLine($"[Doctor] ID: {ID}, Name: {Name}, Age: {Age}, Specialty: {Specialty}");
        }
    }
}
