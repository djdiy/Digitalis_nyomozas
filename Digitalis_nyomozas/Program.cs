namespace Digitalis_nyomozas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user_test = new User("Test_user", 0, "testing");
            Console.WriteLine(user_test);

            Person person_test = new Person("Test_person", 123, "123 éves");
            Console.WriteLine(person_test);
        }
    }
}
