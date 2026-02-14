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



        }
    }
}
