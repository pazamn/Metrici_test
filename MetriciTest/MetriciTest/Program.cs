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

           

            //Console.WriteLine("Enter elements of array: ");
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    matrix[i, j] = randomize.Next(1, 100);
                    Console.Write("{0}\t", matrix[i, j]);
                    //Console.Write("Enter value of [{0}, {1}]:", i, j);
                    //matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
            }

            var min = matrix[0,matrix.GetLength(1)-1];
            int k = 0;
               for (int j = matrix.GetLength(1)-1; j >= 0; j--)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    if (min > matrix[k,j])
                    {
                        min = matrix[k,j];
                    }
                    k++;
                }
                Console.WriteLine();

            Console.WriteLine(min);
            Console.WriteLine("\n");

            Console.ReadLine();
        }
    }
}