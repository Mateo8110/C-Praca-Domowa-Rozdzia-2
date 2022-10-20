namespace Program
{
    class Zadanie
    {
        static void Main(string[] args)
        {
            double a, b, c, delta;
            Console.WriteLine("Podaj wartosc a: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wartosc b: ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wartosc c: ");
            c = double.Parse(Console.ReadLine());
            delta = b * b - 4 * a * c;
            Console.WriteLine("Wynik to: " + delta);



        }
    }
}