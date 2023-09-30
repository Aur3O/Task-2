using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0, point, sum = 0;
            string input;
            int[] points = new int[5];
            int[,] extreme = new int[2, 2] { { 0, 0 }, { 0, 0 } };

            while (x < 5)
            {
                Console.Write("Give points : ");
                input = Console.ReadLine();

                if (int.TryParse(input, out point))
                {
                    points[x] = point;
                    x++;
                }

                else
                {
                    Console.WriteLine("Please enter a number.");
                }
            }

            if (points[0] <= points[1])
            {
                extreme[0, 0] = points[0];
                extreme[1, 0] = points[1];
            }

            else
            {
                extreme[0, 0] = points[1];
                extreme[1, 0] = points[0];
            }

            for (int i = 2; i < points.Length; i++)
            {
                if (points[i] < extreme[0, 0])
                {
                    extreme[0, 0] = points[i];
                    extreme[0, 1] = i;
                }
                else if (points[i] > extreme[1, 0])
                {
                    extreme[1, 0] = points[i];
                    extreme[1, 1] = i;
                }
            }

            points[extreme[0, 1]] = 0;
            points[extreme[1, 1]] = 0;

            for (int i = 0; i < points.Length; i++)
            {
                sum += points[i];
            }

            Console.WriteLine("Total point are " + sum);
        }
    }
}
