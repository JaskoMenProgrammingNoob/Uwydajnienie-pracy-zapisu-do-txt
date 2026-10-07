using System.IO;
class Program
{


    static void Main(string[] args)
    {
        double a = 0;
        double b = 0;
        double c = 0;
        double delta = 0;
        double x1 = 0;
        double x2 = 0;
        double x0 = 0;
        string wyniki = "zero";
        try
        {
            a = double.Parse(args[0]);
            b = double.Parse(args[1]);
            c = double.Parse(args[2]);
            if (double.Parse(args[0]) == 0)
            {
                
                Console.WriteLine("A = 0, to funkcja liniowa!");
                File.WriteAllText("wyniki.txt", "A = 0, to funkcja liniowa!");
                return;
            }

        }
        catch (Exception)
        {
            if (args.Length < 3)
            {
                Console.WriteLine("Należy wprowadzić 3 liczby rzeczywiste !");
               
            }
            else if (args.Length == 3)
            {
                Console.WriteLine("Wprowadzono niepoprawne liczby! ");
                
            }
            
            return;
        }
        Console.WriteLine("Wprowadzono następujące wartości: a = {0}, b = {1}, c = {2}", args);
        Console.Write("Obliczam równanie: ");
        delta = double.Parse(args[1]) * double.Parse(args[1]) - 4 * double.Parse(args[0]) * double.Parse(args[2]);
        if (delta < 0)
        {
            Console.WriteLine("Delta mniejsza od zera - brak rozwiązań.");
            wyniki = "Delta mniejsza od zera - brak rozwiązań.";
        }
        else if (delta == 0)
        {
            Console.Write("Delta = 0, obliczam jedno miejsce zerowe: ");
            x0 = (-double.Parse(args[1]) / 2 * double.Parse(args[0]));
            
            Console.WriteLine($"X0: {x0}");
            wyniki = "Równanie ma jedno rozwiązanie:  \n";
            wyniki += "x0 = " + x0;
        }
        else
        {
            Console.Write("Delta > 0, obliczam dwa miejsca zerowe: ");
            x1 = (-double.Parse(args[1]) - Math.Sqrt(delta) / 2 * double.Parse(args[0]));
            x2 = (-double.Parse(args[1]) + Math.Sqrt(delta) / 2 * double.Parse(args[0]));
            
            Console.WriteLine($"X1: {x1}");
            Console.WriteLine($"X2: {x2}");
            wyniki = "Równanie ma dwa rozwiązania:  \n";
            wyniki += "x1 = " + x1 + "\n";
            wyniki += "x2 = " + x2 + "\n";
            
                
        }

        File.WriteAllText("wynik.txt", wyniki);

    }
    
}

