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
            int[,] matrix = new int[3,3];

            Random randomize = new Random();

            Console.WriteLine("Enter elements of array: ");
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    //matrix[i, j] = randomize.Next(1, 100);
                    //Console.Write("{0}\t", matrix[i, j]);
                    Console.Write("Enter value of [{0}, {1}]:", i, j);
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                    //Console.Write("{0}\t", matrix[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n");

            foreach (var x in matrix)
            {
                Console.Write("{0}\t", x);
            }

            Console.ReadLine();
        }
    }
}