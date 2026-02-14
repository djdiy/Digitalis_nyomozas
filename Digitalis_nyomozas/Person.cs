using System;
using System.Collections.Generic;
using System.Text;

namespace Digitalis_nyomozas
{
    internal class Person
    {
        private string name;
        private int age;
        private string note;

        public Person(string name, int age, string note)
        {
            this.name = name;
            this.age = age;
            this.note = note;
        }

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string Note { get => note; set => note = value; }


        public override string ToString()
        {
            return $"Név: {this.name}, életkor: {this.age}, megjegyzés: {this.note}";
        }
    }
}
