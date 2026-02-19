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
        private List<Evidence> evidences;

        public Suspect(Person person, int suspicion_lvl, string status, List<Evidence> evidences)
        {
            this.person = person;
            this.suspicion_lvl = suspicion_lvl;
            this.status = status;
            this.evidences = evidences;
        }

        public int Suspicion_lvl { get => suspicion_lvl; set => suspicion_lvl = value; }
        public string Status { get => status; set => status = value; }
        internal Person Person { get => person; set => person = value; }
        internal List<Evidence> Evidences { get => evidences; set => evidences = value; }

        public void DecisionEngine()
        {
            Console.WriteLine("Bizonyítékok: ");
            foreach(Evidence e in evidences)
            {
                Console.WriteLine(e);
            }
            Console.Write("Add meg az új gyanusítottsági szintet: ");
            int new_level = Convert.ToInt32(Console.ReadLine());
            if (new_level >= 90)
            {
                Console.WriteLine("figyelem, a gyanusítottsági szint >= 90.");
            }
            this.suspicion_lvl = new_level;
        }
        public override string ToString()
        {
            return $"Gyanusított: {this.person}, gyanusítottsági szint(0-100): {this.suspicion_lvl}, státusz: {this.status}";
        }
    }
}
