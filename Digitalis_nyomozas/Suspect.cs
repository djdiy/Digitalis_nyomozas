using System;
using System.Collections.Generic;
using System.Text;

namespace Digitalis_nyomozas
{
    internal class Suspect
    {
        private Person person;
        private int suspicion_lvl;
        private string status;

        public Suspect(Person person, int suspicion_lvl, string status)
        {
            this.person = person;
            this.suspicion_lvl = suspicion_lvl;
            this.status = status;
        }

        public int Suspicion_lvl { get => suspicion_lvl; set => suspicion_lvl = value; }
        public string Status { get => status; set => status = value; }
        internal Person Person { get => person; set => person = value; }

        public override string ToString()
        {
            return $"Gyanusított: {this.person}, gyanusítottsági szint(0-100): {this.suspicion_lvl}, státusz: {this.status}";
        }
    }
}
