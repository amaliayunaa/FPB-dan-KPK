using System;

namespace KPKdanFPB
{
    class Program
    {
        static void Main(string[] args)
        {
            int bil1, bil2, fpb = 1, kpk;

            Console.WriteLine("Masukkan bilangan1: ");
            bil1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Masukkan bilangan2: ");
            bil2 = int.Parse(Console.ReadLine());

            if (bil1 == 0 || bil2 == 0)
            {
                Console.WriteLine("FPB dan KPK tidak dapat dihitung untuk bilangan 0");
            }
            else
            {
                for (int i = 1; i <= bil1 && i <= bil2; i++)
                {
                    if (bil1 % i == 0 && bil2 % i == 0)
                    {
                        fpb = i;
                    }
                }

                kpk = (bil1 * bil2) / fpb;

                Console.WriteLine("FPB dari " + bil1 + " dan " + bil2 + " adalah " + fpb);
                Console.WriteLine("KPK dari " + bil1 + " dan " + bil2 + " adalah " + kpk);
            }

            Console.ReadKey();
        }
    }
}
