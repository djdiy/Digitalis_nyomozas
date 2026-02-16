namespace Digitalis_nyomozas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Felhasználó teszt
            User user_test = new User("Test_user", 0, "testing");
            Console.WriteLine(user_test);


            //Személy teszt
            Person person_test = new Person("Test_person", 123, "123 éves");
            Console.WriteLine(person_test);



            //Gyanusított teszt
            Person suspect_person_test = new Person("suspected_person", 321, "321 éves és gyanusított");
            Suspect suspect_test = new Suspect(suspect_person_test, 99, "őrizetben");
            Console.WriteLine(suspect_test);




            //Tanú teszt
            Person witness_person_test = new Person("witness_person", 1, "1 éves és tanú");
            Witness witness_test = new Witness(witness_person_test, "láttam", DateOnly.FromDateTime(DateTime.Now));
            Console.WriteLine(witness_test);




            //Bizonyíték teszt
            Evidence evidence_test = new Evidence(1, "fotó", "wow, ez nagyon biztos", 5);
            Console.WriteLine(evidence_test);


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();



            //Ügy teszt
            List<Person> people = new List<Person>();
            Person person_test1 = new Person("Test_person1", 1231, "1231 éves");
            Person person_test2 = new Person("Test_person2", 1232, "1232 éves");
            Person person_test3 = new Person("Test_person3", 1233, "1233 éves");

            people.Add(person_test1);
            people.Add(person_test2);
            people.Add(person_test3);

            List<Evidence> evidence = new List<Evidence>();
            Evidence evidence_test1 = new Evidence(2, "fotó1", "wow, ez nagyon biztos1", 5);
            Evidence evidence_test2 = new Evidence(3, "fotó2", "wow, ez nagyon biztos2", 5);
            Evidence evidence_test3 = new Evidence(4, "fotó3", "wow, ez nagyon biztos3", 5);

            evidence.Add(evidence_test1);
            evidence.Add(evidence_test2);
            evidence.Add(evidence_test3);

            Case case_test = new Case(0, "Az ügy", "nagyon rejtélyes", "folyamatban", people, evidence);
            Console.WriteLine(case_test);


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //Ügy állapot teszt
            CaseStatus status_test = new CaseStatus("folyamatban");
            Console.WriteLine(status_test);
            status_test.allapotvaltozas("kész");
            Console.WriteLine(status_test);



        }
    }
}
