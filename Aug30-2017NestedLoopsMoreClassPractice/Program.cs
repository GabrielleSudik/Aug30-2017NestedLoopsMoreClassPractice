using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aug30_2017NestedLoopsMoreClassPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //nested loops
            //loops within loops

            for (int i = 1; i <= 2; i++)  //for two rows...
            {
                for (int j = 1 ; j <=4; j++)  //do this for four columns.
                {
                    Console.Write(j + " "); //columns
                }

                Console.WriteLine(); //rows
            }
            Console.WriteLine();

            //now print a triangle

            int n = 4;
            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <=row; col++)
                {
                    Console.Write(col + " ");
                }
                Console.WriteLine();
            }

            //class exercises:

            //loop ask a user for an integer until they get one divisible by three

            Console.WriteLine("\nLet's test your mental math.");

            bool isDivBy3 = false;

            while (isDivBy3 == false)
            {
                Console.WriteLine("Please enter a number divisible by three.");
                int guess = int.Parse(Console.ReadLine());

                if (guess % 3 == 0)
                {
                    isDivBy3 = true;
                    Console.WriteLine("Divisible by three. Good job!");
                    Console.WriteLine("Press enter to continue.")    ;
                }
                else
                {
                    Console.WriteLine("Wrong. Guess again.");
                }
                
            }

            //print a 5x5 multiplication table

            Console.WriteLine("\nHere's a mulitplication table.\n");

            for (int row = 1; row <=5; row++)
            {
                for (int col = 1; col <=5; col++)
                {
                    Console.Write($"{row} x {col} = {row * col}. ");
                }
                Console.WriteLine();
            }

            //make array of favorite movies.
            //print them out, except ones starting with a vowel
            //hint: "startsWith()" ** look it up **

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
