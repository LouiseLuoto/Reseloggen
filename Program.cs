namespace Reseloggen;

class Program
{
    static void Main(string[] args)
    {
        
    
        bool isRunning = true;

        List<Destination> list = new List<Destination>();

        while (true)
        {
            System.Console.WriteLine("Gör ett val i menyn");
            System.Console.WriteLine("[L]ägg till resmål");
            System.Console.WriteLine("[T]a bort resmål");
            System.Console.WriteLine("[V]isa alla resmål");
            System.Console.WriteLine("[R]ensa reselogg");
            System.Console.WriteLine("[A]vsluta");

            string choice = Console.ReadLine().ToLower();

            switch (choice)
            {
                case ("l"): 
                    Console.WriteLine("Vilket resmål vill du lägga till? ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Vilket år reste du?");
                    int year = int.Parse(Console.ReadLine());
                    Console.WriteLine("Lägg till en beskrivning av resmålet? ");
                    string description = Console.ReadLine();
                    Console.WriteLine("Ge resan ett betyg mellan 1-5? ");
                    int grade = int.Parse(Console.ReadLine());
                    var d = new Destination(name, description, grade, year);
                    list.Add(d);
                    break;
                case ("t"): 
                    Console.WriteLine("Vilket resmål vill du ta bort? ");
                    .RemoveAt(Console.ReadLine());
                    break;
                case ("v"):
                    foreach( Destination x in list)
                        System.Console.WriteLine(x.name);
                    break;
                case ("r"): 
                    System.Console.WriteLine("[R]");
                    break;
                case ("a"): 
                    isRunning = false;
                    break;
            }

        }




        





    }
}
