using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

namespace Digitalis_nyomozas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataStore datastore = new DataStore();
            string choice;
            do
            {
                Console.WriteLine($"===== FOMENU =====\n" +
                $"1. új ügy felvétele\n" +
                $"2. személy hozzáadása\n" +
                $"3. bizonyíték rögzítése\n" +
                $"4. ügy állapotának módosítása\n" +
                $"5. idővonal esemény hozzáadása\n" +
                $"6. gyanúsított értékelése bizonyítékok alapján\n" +
                $"'q' kilépés");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Ügy azonosító: ");
                        int newcase_id = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Ügy cím: ");
                        string newcase_title = Console.ReadLine();

                        Console.Write("Ügy leírás: ");
                        string newcase_description = Console.ReadLine();

                        Console.Write("Ügy állapot: ");
                        string newcase_state = Console.ReadLine();
                        datastore.Cases.Add(new Case(newcase_id, newcase_title, newcase_description, newcase_state));
                        break;

                    case "2":
                        Console.Write("Személy neve: ");
                        string person_name = Console.ReadLine();

                        Console.Write("Személy kora: ");
                        int person_age = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Megjegyzés: ");
                        string person_note = Console.ReadLine();
                        datastore.People.Add(new Person(person_name, person_age, person_note));
                        break;

                    case "3":
                        Console.Write("Bizonyíték azonosító: ");
                        int evidence_id = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Bizonyíték típus: ");
                        string evidence_type = Console.ReadLine();

                        Console.Write("Bizonyíték leírás: ");
                        string evidence_description = Console.ReadLine();

                        Console.Write("Bizonyíték megbízhatóság(1-5): ");
                        int evidence_trustworthiness = Convert.ToInt32(Console.ReadLine());

                        datastore.Evidences.Add(new Evidence(evidence_id, evidence_type, evidence_description, evidence_trustworthiness));
                        break;

                    case "4":

                        Console.Write("Az ügy azonosítója: ");
                        int casestatus_id = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Az új státusz: ");
                        string newStatus = Console.ReadLine();

                        datastore.CaseStatus(casestatus_id, newStatus);
                        break;



                    case "5":
                        Console.Write("Dátum: ");
                        DateTime dateTime = Convert.ToDateTime(Console.ReadLine());

                        Console.Write("Esemény leírása: ");
                        string dateDescription = Console.ReadLine();

                        datastore.Timelinevents.Add(new TimelineEvent(dateTime, dateDescription));
                        break;



                    case "6":
                        //nem tudom
                        break;

                    case "q":
                        break;
                }
            } while (choice != "q");
        }
    }
}
