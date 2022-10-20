namespace Program
{
    class Zadanie
    {
        static void Main(string[] args)
        {
            double F, C;
            Console.WriteLine("Podaj temp. w stopniach Celsjusza");
            C = double.Parse(Console.ReadLine());
            F = 32 + 9/5 * C;
            Console.WriteLine(F);
            Console.ReadKey();
        }
    }
}

