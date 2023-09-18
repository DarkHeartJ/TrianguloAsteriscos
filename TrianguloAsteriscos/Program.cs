namespace TrianguloAsteriscos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("Introduce la altura del triangulo: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}