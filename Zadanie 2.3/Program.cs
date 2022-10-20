using System;

namespace Zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            double waga, wzrost, BMI;

            Console.WriteLine("Podaj wzrost w metrach: ");
            wzrost = Double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wage ciała w Kg: ");
            waga = Double.Parse(Console.ReadLine());
            BMI = (waga / (wzrost * wzrost));
            Console.WriteLine(Math.Round(BMI, 2));
            Console.ReadKey();
            
        }
    }
}