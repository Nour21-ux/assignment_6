using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace assignment_6
{
    internal class Engineer:Person
    {
        public string Field { get; set; } = string.Empty;

        public new void Greet()
        {
            Console.WriteLine("I am an engineer.");
        }

        public override void Display()
        {
            Console.WriteLine($"[Engineer] ID: {ID}, Name: {Name}, Age: {Age}, Field: {Field}");
        }
    }
}
