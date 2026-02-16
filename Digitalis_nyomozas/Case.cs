using System;
using System.Collections.Generic;
using System.Text;

namespace Digitalis_nyomozas
{
    internal class Case
    {
        private int case_id;
        private string title;
        private string case_description;
        private string case_state;
        private List<Person> case_people;
        private List<Evidence> case_evidence;
        private List<Suspect> suspects;

        public Case(int case_id, string title, string case_description, string case_state)
        {
            this.case_id = case_id;
            this.title = title;
            this.case_description = case_description;
            this.case_state = case_state;
            this.case_people = new List<Person>();
            this.case_evidence = new List<Evidence>();
            this.suspects = new List<Suspect>();
        }

        public int Case_id { get => case_id; set => case_id = value; }
        public string Title { get => title; set => title = value; }
        public string Case_description { get => case_description; set => case_description = value; }
        public string Case_state { get => case_state; set => case_state = value; }
        internal List<Person> Case_people { get => case_people; set => case_people = value; }
        internal List<Evidence> Case_evidence { get => case_evidence; set => case_evidence = value; }
        internal List<Suspect> Suspects { get => suspects; set => suspects = value; }

        public void DecisionEngine(string name)
        {
            foreach(Evidence e in case_evidence)
            {
                Console.WriteLine(e);
            }
            int new_level = Convert.ToInt32(Console.ReadLine());
            if(new_level >= 90)
            {
                Console.WriteLine("figyelem, a gyanusítottsági szint >= 90.");
            }
            foreach(Suspect s in suspects)
            {
                if(s.Person.Name == name)
                {
                    s.Suspicion_lvl = new_level;
                }
            }
        }
        public override string ToString()
        {
            string people_string = "";
            string evidence_string = "";

            foreach (Person person in case_people)
            {
                people_string += person + " ";
            }

            foreach(Evidence evidence in case_evidence)
            {
                evidence_string += evidence + " ";
            }
            return $"Ügy ID: {this.case_id}, cím: {this.title}, leírás: {this.case_description}, állapot: {this.case_state}\nhozzátartozó személyek: {people_string}\nhozzátartozó bizonyíték: {evidence_string}";
        }
    }
}
