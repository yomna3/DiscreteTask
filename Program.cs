using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write(" Enter the Minimum number : ");
            int N1 = int.Parse(Console.ReadLine());
            Console.Write(" Enter the Maximum number : ");
            int N2 = int.Parse(Console.ReadLine());
            for (int x = N1; x <= N2; x++)
            {
                int r = 0;
                int M = (int)Math.Sqrt(x);
                for (int y = 2; y<=M; y++)
                {
                    if (x % y == 0)
                    {

                        r++;

                    }

                }
                if (r == 0)
                {
                    Console.WriteLine(x);
                }
            }




















        }
    }
}
