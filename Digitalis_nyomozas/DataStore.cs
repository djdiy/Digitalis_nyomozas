using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Digitalis_nyomozas
{
    internal class DataStore
    {
        private List<User> users = new List<User>();
        private List<Case> cases = new List<Case>();
        private List<Person> people = new List<Person>();
        private List<Evidence> evidences = new List<Evidence>();
        private List<TimelineEvent> timelinevents = new List<TimelineEvent>();


        internal List<User> Users { get => users; set => users = value; }
        internal List<Case> Cases { get => cases; set => cases = value; }
        internal List<Person> People { get => people; set => people = value; }
        internal List<Evidence> Evidences { get => evidences; set => evidences = value; }
        internal List<TimelineEvent> Timelinevents { get => timelinevents; set => timelinevents = value; }

        public void EvidenceManager()
        {
            Console.WriteLine("1. bizonyíték hozzáadása\n2. bizonyíték törlése\n3. bizonyíték listázása");
            switch (Console.ReadLine())
            {
                case "1": //bizonyíték hozzáadása
                    int id = Convert.ToInt32(Console.ReadLine());
                    string type = Console.ReadLine();
                    string description = Console.ReadLine();
                    int trustworthiness = Convert.ToInt32(Console.ReadLine());

                    evidences.Add(new Evidence(id, type, description, trustworthiness));
                    break;

                case "2": //bizonyíték törlése
                    id = Convert.ToInt32(Console.ReadLine());
                    evidences.RemoveAt(id);
                    break;

                case "3": //bizonyítékok listázása
                    foreach (Evidence e in evidences)
                    {
                        Console.WriteLine(e);
                    }
                    break;
            }
        }

        public void CaseStatus(int id, string newState)
        {
            foreach (Case c in cases)
            {
                if(c.Case_id == id)
                {
                    c.Case_description = newState;
                }
            }
        }

        public void CaseManager()
        {
            Console.WriteLine("1. új ügy létrehozása\n2. ügyek listázása\n3. személyek és bizonyítékok hozzárendelése");
            switch (Console.ReadLine())
            {
                case "1": //új ügy létrehozása
                    int case_id = Convert.ToInt32(Console.ReadLine());
                    string title = Console.ReadLine();
                    string case_description = Console.ReadLine();
                    string case_state = Console.ReadLine();

                    cases.Add(new Case(case_id, title, case_description, case_state));
                    break;
                case "2": //ügyek listázása
                    foreach (Case c in cases)
                    {
                        Console.WriteLine(c);
                    }
                    break;
                case "3": //személyek és bizonyítékok hozzárendelése
                    case_id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Személyt(1) vagy bizonyítékot(2) szeretnél hozzárendelni?");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            string name = Console.ReadLine();
                            int age = Convert.ToInt32(Console.ReadLine());
                            string note = Console.ReadLine();
                            Person per1 = new Person(name, age, note);
                            people.Add(per1);
                            foreach(Case c in cases)
                            {
                                if (c.Case_id == case_id)
                                {
                                    c.Case_people.Add(per1);
                                }
                            }
                            break;
                        case "2":
                            int id = Convert.ToInt32(Console.ReadLine());
                            string type = Console.ReadLine();
                            string description = Console.ReadLine();
                            int trustworthiness = Convert.ToInt32(Console.ReadLine());
                            Evidence ev1 = new Evidence(id, type, description, trustworthiness);
                            evidences.Add(ev1);
                            foreach(Case c in cases)
                            {
                                if(c.Case_id == case_id)
                                {
                                    c.Case_evidence.Add(ev1);
                                }
                            }
                            break;
                    }
                    break;
            }
        }
    }
}
