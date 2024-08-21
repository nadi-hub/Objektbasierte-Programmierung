namespace Funktionen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                ShowMenu();
                string s = ReadSelection();
                if (s == "e")
                {
                    Console.WriteLine("Programm wird beendet");
                    break;
                }
                int a = 0;
                int b = 0;

                if (s != "A")
                {
                     a = ReadInt();
                     b = ReadInt();
                } else
                {
                    Console.WriteLine("Anzahl Werte?");
                    int anzahlWerte = ReadInt();
                    int[] values = ReadValues(anzahlWerte);
                    double average = MyMath.Average(values);
                    Console.WriteLine($"Der Mittelwert der eingegebenen Parametern beträgt: {average}");
                    Console.WriteLine($"Die kleinste Zahl ist: {MyMath.Min(values)}");
                }
                switch (s)
                {
                    case "ggT":
                        int ggT = MyMath.Calc_ggT(a, b);
                        ShowResult(s, a, b, ggT);
                        break;

                    case "kgV":
                        int kgV = MyMath.Calc_kgV(a, b);
                        ShowResult(s, a, b, kgV);
                        break;

                    case "ggT_r":
                        int ggT_r = MyMath.Calc_ggT_r(a, b);
                        ShowResult(s, a, b, ggT_r);
                        break;

                }
                
            }
            
        }
        static int ReadInt()
        {
            int x;
            do
            {
                Console.WriteLine("Gib eine Zahl ein");
                string s = Console.ReadLine();
                int.TryParse(s, out x);
            } while (x <= 0);

            Console.WriteLine("Danke");
            return x;
        }
        static void ShowResult(string operation, int a, int b, int result)
        {
            Console.WriteLine(operation + $" von {a} und {b} ist {result}");
        }
        static void ShowMenu()
        {
            Console.WriteLine("Bitte Operation eingeben:");
            Console.WriteLine("\t ggT für gemeinsamer Teiler");
            Console.WriteLine("\t kgV für gemeinsames Vielfach");
            Console.WriteLine("\t e für Ende");
            Console.WriteLine("\t ggT_r für rekursiven gemeinsamen Teiler");
            Console.WriteLine("\t A für Array");

        }
        static string ReadSelection()
        {
            string s;
            do
            {
                s = Console.ReadLine();
            } while (s != "kgV" && s != "ggT" && s != "e" && s != "ggT_r" && s != "A");

            Console.WriteLine("Danke");
            return s;

            
        }
        static int[] ReadValues(int length)
        {
            int i = 0;
            int[] values = new int[length];
            while (i < length)
            {
                values[i++] = ReadInt();
            }
            return values;
        }






    }
}
