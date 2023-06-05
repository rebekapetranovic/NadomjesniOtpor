using System;

namespace prvi
{
    class Program
    {
        /// <summary>
        /// RAČUNANJE NADOMJESNOG OTPORA
        /// </summary>
        static void Main()
        {
            int r1;
            int r2;
            int r3;
            double rUk;
            Console.Write("\nUpišite vrijednost prvog otpornika: ");
            r1 = int.Parse(Console.ReadLine());
            Console.Write("\nUpišite vrijednot drugog otpornika: ");
            r2 = int.Parse(Console.ReadLine());
            Console.Write("\nUpišite vrijednot trećeg otpornika: ");
            r3 = int.Parse(Console.ReadLine());
            rUk = (r2 * r3) / (r2 + r3) + r1;
            Console.WriteLine("Nadomjesni otpor otpornika iznosi: {0}", rUk);
        }
    }
}