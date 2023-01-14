namespace Cwiczenia_4_Zad_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            byte n = 1, m;

            byte w;

            Console.WriteLine("Wprowadz liczbe wierszy");

            w = Convert.ToByte(Console.ReadLine());

            while (n <= w)

            {
                m = 1;
                while (m <= w)
                {
                    if (n == 1 | n == w | m == 1 | m == w)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                    m++;
                }
                Console.WriteLine();
                n++;
            }

        }
    }
}