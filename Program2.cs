using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*          int i;
                      for(i = 1; i<=1000; i++)
                      {

                          Console.WriteLine(i);
                      }
                      Console.ReadKey();

          */
            /*
                        int i;
                        for (i = 2; i <= 1000; i += 2)
                        {

                            Console.WriteLine(i);
                        }
                        Console.ReadKey();

            */
            /*
                        int potega;

                        Console.Write("Podaj potege: ");
                        potega = Int32.Parse(Console.ReadLine());




                        for ( int i = 0; i <= potega; i++)
                        {

                            Console.WriteLine("{0},",Math.Pow(2, i));
                        }
                        Console.ReadKey();
            */
            /*
                        int x;
                        int sum = 0;

                        Console.Write("Podaj x: ");
                        x = Int32.Parse(Console.ReadLine());




                        for (int i = 0; i <= x; i++)

                            sum += i;
                            Console.WriteLine(sum);

                        Console.ReadKey();
            */

            for (int j = 0; j < 10; j++)
            {
                for (int i = 0; i < 10; i++)
                    Console.Write("*\t");
                Console.WriteLine();
            }


            Console.ReadKey();

        }
    }
}
