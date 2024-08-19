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
            Console.WriteLine(ggT);
            Console.WriteLine(kgV);
            
        }
    }
}
