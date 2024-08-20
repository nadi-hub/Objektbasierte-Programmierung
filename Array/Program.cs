namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int[] arr = { 1, 2, 5 };
            string[] Persons = { "Atifa", "Nadja", "Maren" };
            int[] person2 = new int[3];
            Console.WriteLine(Persons[1]);
            Console.WriteLine(arr.Length);
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 2)
                {
                    continue;
                }
                Console.WriteLine(arr[i]);

            }
        }
    }
}
