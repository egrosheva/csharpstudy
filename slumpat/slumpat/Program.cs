//syntax error System with small letter
using System;

namespace Uppgift_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Deklaration av variabler
            Random slumpat = new Random(); // skapar ett random objekt
            //logical error missing interval 1,20
            int speltal = slumpat.Next(1,20); // anropar Next metoden för att skapa ett slumptal mellan 1 och 20
            // läs på, vad är overload metoder? https://msdn.microsoft.com/en-us/library/system.random.next(v=vs.110).aspx
            bool spela = true; // Variabel för att kontrollera om spelet ska fortsätta köras
            //logical error missing ! operator, while loop never executed
            while (spela)
            {
                Console.Write("\n\tGissa på ett tal mellan 1 och 20: ");
                //int tal = Convert.ToInt32(Console.ReadLine());
                int tal;
                while (Int32.TryParse(Console.ReadLine(), out tal) != true) ;

                if (tal < speltal)
                {
                    Console.WriteLine("\tDet inmatade talet " + tal + " är för litet, försök igen.");
                }
                
                if (tal > speltal)
                {   //syntax error missing + operator
                    Console.WriteLine("\tDet inmatade talet " + tal + " är för stort, försök igen.");
                }
                //syntax error wrong operator missing one =
                if (tal == speltal)
                {  //logical error, missing curly braces { } this means only the Console writeln was executed and
                   //spelat become false even if the user didnt guess the correct value
                    Console.WriteLine("\tGrattis, du gissade rätt!");
                    spela = false;

                }
            }
        }
    }
}
