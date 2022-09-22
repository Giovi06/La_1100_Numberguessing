using System;
namespace Numberguessing
{
    class Generator
    {
        static void Main(string[] args)
        {
            bool spielbereit;
            bool nochmal = true;
            int gerateneZahl;
            bool harterModus = false;
            try
            {
                Console.WriteLine("Sind Sie bereit? ");
                Console.WriteLine("true/false");
                spielbereit = Convert.ToBoolean(Console.ReadLine());
            } catch (Exception e)
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
                    int geschafft100 = 0;
                    int geschafft1000 = 0;

                    switch (nochmal)
                    {
                        case false:
                            Console.WriteLine("Okay, schade :( Hoffentlich spielen Sie bald wieder!");
                            break;
                        case true:
                            switch (harterModus)
                            {

                                case true:
                                    anzahlVersuche = 0;
                                    geschafft1000 = 0;
                                    Random grosseRandom = new Random();
                                    int grosseRandomNumber = grosseRandom.Next(1, 1000);
                                    do
                                    {
                                        try
                                        {
                                            Console.WriteLine(grosseRandomNumber);
                                            Console.WriteLine("Geben Sie bitte eine Zahl zwischen 1-1000 ein: ");
                                            gerateneZahl = Convert.ToInt32(Console.ReadLine());
                                        }
                                        catch (Exception e)
                                        {
                                            Console.WriteLine(e.ToString());
                                            continue;
                                        }
                                        switch (gerateneZahl)
                                        {
                                            case int n when (n < 1):
                                            case int m when (m > 1000):
                                                Console.WriteLine("Ungültige Eingabe: Ihre Zahl befindet sich nicht zwischen 1-1000!");
                                                anzahlVersuche = ++anzahlVersuche;
                                                break;
                                            case int n when (gerateneZahl == grosseRandomNumber):
                                                geschafft1000 = 1;
                                                anzahlVersuche = ++anzahlVersuche;

                                                switch (anzahlVersuche)
                                                {
                                                    case int x when (anzahlVersuche == 1):
                                                        Console.WriteLine("Glückwunsch, Sie haben es geschafft mit nur einem Versuch! ");
                                                        break;
                                                    case int x when (anzahlVersuche < 6):
                                                        Console.WriteLine("Super, Sie haben es geschafft mit nur " + anzahlVersuche + " Versuchen die richtige Zahl zu erraten!");
                                                        break;
                                                    case int x when (anzahlVersuche < 10):
                                                        Console.WriteLine("Okay, Sie haben es geschafft mit " + anzahlVersuche + " Versuchen die richtige Zahl zu erraten. Sie können das sicher besser!");
                                                        break;
                                                    case int x when (anzahlVersuche < 21):
                                                        Console.WriteLine("Sie haben mit " + anzahlVersuche + " Versuchen die richtige Zahl erraten. Versuchen sie es doch noch einmal.");
                                                        break;
                                                    case int x when (anzahlVersuche > 20):
                                                        Console.WriteLine("Sind wir ehrlich " + (anzahlVersuche - 1) + "Mal eine Zahl zu erraten und es erst beim " + anzahlVersuche + "ten Mal zu erraten ist garnicht mal so gut.");
                                                        break;
                                                }
                                                break;

                                            case int n when (gerateneZahl > 0 && gerateneZahl < 1001):
                                                if (gerateneZahl < grosseRandomNumber)
                                                {
                                                    Console.WriteLine("Die Zufallszahl liegt über " + gerateneZahl);
                                                }
                                                else if (gerateneZahl > grosseRandomNumber)
                                                {
                                                    Console.WriteLine("Die Zufallszahl liegt unter " + gerateneZahl);
                                                }
                                                anzahlVersuche = ++anzahlVersuche;
                                                break;
                                        }

                                    } while (geschafft1000 == 0);
                                    break;

                                case false:
                                    anzahlVersuche = 0;
                                    geschafft100 = 0;
                                    Random random = new Random();
                                    int randomNumber = random.Next(1, 100);
                                    do
                                    {
                                        try
                                        {
                                            Console.WriteLine(randomNumber);
                                            Console.WriteLine("Geben Sie bitte eine Zahl zwischen 1-100 ein: ");
                                            gerateneZahl = Convert.ToInt32(Console.ReadLine());
                                        }
                                        catch (Exception e)
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
                                                geschafft100 = 1;
                                                anzahlVersuche = ++anzahlVersuche;

                                                switch (anzahlVersuche)
                                                {
                                                    case int x when (anzahlVersuche == 1):
                                                        Console.WriteLine("Glückwunsch, Sie haben es geschafft mit nur einem Versuch geschafft! ");
                                                        break;
                                                    case int x when (anzahlVersuche < 6):
                                                        Console.WriteLine("Super, Sie haben es geschafft mit nur " + anzahlVersuche + " Versuchen die richtige Zahl zu erraten!");
                                                        break;
                                                    case int x when (anzahlVersuche < 10):
                                                        Console.WriteLine("Okay, Sie haben es geschafft mit " + anzahlVersuche + " Versuchen die richtige Zahl zu erraten. Sie können das sicher besser!");
                                                        break;
                                                    case int x when (anzahlVersuche < 21):
                                                        Console.WriteLine("Sie haben mit " + anzahlVersuche + " Versuchen die richtige Zahl erraten. Versuchen sie es doch noch einmal.");
                                                        break;
                                                    case int x when (anzahlVersuche > 20):
                                                        Console.WriteLine("Sind wir ehrlich " + (anzahlVersuche - 1) + "Mal eine Zahl zu erraten und es erst beim " + anzahlVersuche + "ten Mal zu erraten ist garnicht mal so gut.");
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

                                    } while (geschafft100 == 0);
                                    break;
                            }
                            break;
                    }
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
                        Console.WriteLine("Super, das freut mich");
                        harterModus = false;
                        switch (anzahlVersuche)
                        {
                            case < 6:
                                Console.WriteLine("Möchten Sie eine Zahl zwischen 1-1000? True/False");
                                harterModus = Convert.ToBoolean(Console.ReadLine());
                                break;
                        }
                    }
                } while (nochmal == true);
            }
        } 
    }
}
