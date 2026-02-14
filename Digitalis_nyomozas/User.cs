using System;
using System.Collections.Generic;
using System.Text;

namespace Digitalis_nyomozas
{
    internal class User
    {
        private string name;
        private int id;
        private string role;

        public User(string name, int id, string role)
        {
            this.name = name;
            this.id = id;
            this.role = role;
        }

        public string Name { get => name; set => name = value; }
        public int Id { get => id; set => id = value; }
        public string Role { get => role; set => role = value; }






        public override string ToString()
        {
            return $"Név: {this.name}, szerepkör: {this.role}, ID: {this.id}";
        }
    }
}
