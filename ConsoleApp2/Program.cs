using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Var god mata in förnamn");
            string förnamn = Console.ReadLine();
            Console.WriteLine("Var god mata in efternamn");
            string efternamn = Console.ReadLine();
            Console.WriteLine("Var god mata in ålder");
            string grattis = "Grattis";
            string strålder = Console.ReadLine();
            int ålder = Convert.ToInt32(strålder);
            if (ålder <65)
            {
                string förung1 = "bara";
                string förung2 = "år kvar till pension.";
                ålder = 65 - ålder;
                string förung = grattis + " " + förnamn + " " + efternamn + " " + förung1 + " " + ålder + förung2 + " ";
                Console.WriteLine(förung);
            } // Här slår vi ihop variablerna för att få fram ett svar i konsolen om personen är förung.
            else
            {
                string pensionär1 = "hoppas du njuter av din pension.";
                string pensionär = grattis + " " + förnamn + " " + efternamn + " " + pensionär1 + ålder;
                Console.WriteLine(pensionär);
            }; // Här slår vi ihop variablerna för att få fram ett svar i konsolen om personen redan har gått i pension
            Console.WriteLine("Tryck på en knapp för att avsluta");
            Console.ReadLine();

            
             
        }
    }
}
