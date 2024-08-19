namespace Funktionen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 20;
            int b = 10;
            int ggT = MyMath.Calc_ggT(a, b);
            int kgV = MyMath.Calc_kgV(a, b);
            ShowResult("ggT", a, b, ggT);
            ShowResult("kgV", a, b, kgV);
            int eingabe = ReadInt();
            Console.WriteLine(eingabe);
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
    }
}
