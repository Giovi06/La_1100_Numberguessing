using System;
namespace Numberguessing
{
    class Generator
    {
        static void Main(string[] args)
        {
            bool spielbereit;
            bool nochmal;
            int gerateneZahl;
            try
            {
                Console.WriteLine("Sind Sie bereit? ");
                Console.WriteLine("true/false");
                spielbereit = Convert.ToBoolean(Console.ReadLine());
            }catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return;
            }
            if (spielbereit == false)
            {
                Console.Write(" ");
            }
            else
            {
                do
                {
                    int anzahlVersuche = 0;
                    int geschafft = 0;
                    Random random = new Random();
                    int randomNumber = random.Next(1, 100);
                    do
                    {
                        try
                        {
                            //Console.WriteLine(randomNumber);
                            Console.WriteLine("Geben Sie bitte eine Zahl zwischen 1-100 ein: ");
                            gerateneZahl = Convert.ToInt32(Console.ReadLine());
                        }catch (Exception e)
                        {
                            Console.WriteLine(e.ToString());
                            continue;
                        }
                        switch (gerateneZahl)
                        {
                            case int n when (n < 1):
                            case int m when (m > 100):
                                Console.WriteLine("Ungültige Eingabe: Ihre Zahl befindet sich nicht zwischen 1-100!");
                                anzahlVersuche = ++anzahlVersuche;
                                break;

                            case int n when (gerateneZahl == randomNumber):
                                geschafft = 1;
                                anzahlVersuche = ++anzahlVersuche;

                                switch (anzahlVersuche)
                                {
                                    case int x when (anzahlVersuche == 1):
                                        Console.WriteLine("Glückwunsch, Sie haben es geschafft mit nur einem Versuch! ");
                                        break;
                                    case int x when (anzahlVersuche < 6):
                                        Console.WriteLine("Super, Sie haben es geschafft mit nur "+ anzahlVersuche + " Versuchen die richtige Zahl zu erraten!");
                                        break;
                                    case int x when (anzahlVersuche < 10):
                                        Console.WriteLine("Okay, Sie haben es geschafft mit " + anzahlVersuche + " Versuchen die richtige Zahl zu erraten. Sie können das sicher besser!");
                                        break;
                                    case int x when (anzahlVersuche < 21):
                                        Console.WriteLine("Sie haben mit " + anzahlVersuche + " Versuchen die richtige Zahl erraten. Versuchen sie es doch noch einmal.");
                                        break;
                                    case int x when (anzahlVersuche > 20):
                                        Console.WriteLine("Sind wir ehrlich "+ (anzahlVersuche -1)  + "Mal eine Zahl zu erraten und es erst beim "+ anzahlVersuche + "ten Mal zu erraten ist garnicht mal so gut.");
                                        break;
                                }
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
                                anzahlVersuche = ++anzahlVersuche;
                                break;
                        }

                    } while (geschafft == 0);
                    try
                    {
                        Console.WriteLine(" Möchten Sie eine weitere Runde spielen? True/False");
                        nochmal = Convert.ToBoolean(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.ToString());
                        return;
                    }
                    if (nochmal == true)
                    {
                        Console.WriteLine("Okay, super das Freut mich");
                    }
                    else
                    {
                        Console.WriteLine("Okay, schade :( Hoffentlich spielen Sie bald wieder!");
                    }

                } while (nochmal == true) ;
            }
        }
    }
}
// catch (Exception e)
// {
//   Console.WriteLine(e.ToString());
// }
