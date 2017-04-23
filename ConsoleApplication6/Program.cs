using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;
            Console.WriteLine("Please enter an integer for the size of your star box: ");
            input = int.Parse(Console.ReadLine());
            PrintStars(input);
        }
        public static void PrintStars(int input)
        {
            string star = "*";

            for (int i = 0; i < input; i++)
            {
                for (int j = 0; j < input; j++)
                {
                    Console.Write(star);
                }
                Console.WriteLine();
            }
        }
    }
}
