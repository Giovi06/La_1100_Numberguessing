using System;
namespace Numberguessing
{
    class Generator
    {
        static void Main(string[] args)
        {
            
            int geschafft = 0;
            bool spielbereit;
            bool nochmal;
            int gerateneZahl;
            do
            {
                Console.WriteLine("Sind Sie bereit? ");
                Console.WriteLine("true/false");
                Random random = new Random();
                int randomNumber = random.Next(1, 100);
                
                spielbereit = Convert.ToBoolean(Console.ReadLine());
                    if (spielbereit == false)
                    {
                        Console.Write(" ");
                    }
                    else
                    {

                        do
                        {
                       
                            Console.WriteLine(randomNumber);
                            Console.WriteLine("Geben Sie bitte eine Zahl zwischen 1-100 ein: ");
                            gerateneZahl = Convert.ToInt32(Console.ReadLine());
                       
                            switch (gerateneZahl)
                            {
                                case int n when (n < 1):
                                case int m when (m > 100):
                                    Console.WriteLine("Ungültige Eingabe: Ihre Zahl befindet sich nicht zwischen 1-100!");
                                    break;
                                case int n when (gerateneZahl == randomNumber):
                                    Console.WriteLine("Super Sie haben die richtige Nummer geraten!!");
                                    geschafft = 1;
                                    break;
                                case int n when (gerateneZahl > 0 && gerateneZahl < 101):
                                    if (gerateneZahl < randomNumber)
                                    {
                                        Console.WriteLine("Die Zufallszahl liegt über " + gerateneZahl);
                                    }
                                    else if (gerateneZahl > randomNumber)
                                    {
                                        Console.WriteLine("Die Zufallszahl liegt unter " + gerateneZahl);
                                    }
                                    break;
                            }
                        } while (geschafft == 0);
                    }
                    Console.WriteLine(" Möchten Sie eine weitere Runde spielen? True/False");
                    nochmal = Convert.ToBoolean(Console.ReadLine());
                
            } while (nochmal == true);
        }
    }
}
// catch (Exception e)
//{
//  Console.WriteLine(e.ToString());
//}