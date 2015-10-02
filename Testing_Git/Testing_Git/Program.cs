using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Testing_Git
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            try
            {
                i = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Uncorrect input!");
            }
            for (int j = 0; j < i; j++)
            {
                Console.WriteLine("Hello World!");
            }
            Console.ReadKey();
        }
    }
}
