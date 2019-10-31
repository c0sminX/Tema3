using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            double valoare,tva;
            int cota;
            Console.Write("Introduceti valoarea fara TVA: ");
            valoare = Convert.ToDouble(Console.ReadLine());
            Console.Write("Introduceti cota TVAului: ");
            cota = Convert.ToInt32(Console.ReadLine());
            tva = (double)cota / 100 * valoare;
            Console.WriteLine("Valoare TVA: {0}", tva);
            Console.WriteLine("Valoare factura + TVA: {0}", valoare + tva);

        }
    }
}
