using System;
using System.Collections.Generic;
using System.Text;

namespace assignment_6
{
    public class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public void Greet()
        {
            Console.WriteLine("I am a person.");
        }

        public virtual void Display()
        {
            Console.WriteLine($"ID: {ID}, Name: {Name}, Age: {Age}");
        }
    }
}
