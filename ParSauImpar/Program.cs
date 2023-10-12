namespace ParSauImpar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("a="); a = int.Parse(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("par");
            }
            else
            {
                Console.WriteLine("impar");
            }
        }
    }
}