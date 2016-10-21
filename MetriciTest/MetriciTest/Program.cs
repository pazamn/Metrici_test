using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetriciTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Hello World");
            Console.WriteLine();

            
            int[,] matrix = new int[2,2];
            var rows = matrix.GetLength(1);
            var colums = matrix.GetLength(1);

            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.ForegroundColor=ConsoleColor.DarkGray;

                    Console.Write("Enter value of [{0}, {1}]: ", i, j);

                    string stringValue = Console.ReadLine();
                }
            }

            
            
            Console.ReadLine();
        }
    }
}
