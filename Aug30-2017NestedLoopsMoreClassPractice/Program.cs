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

            Console.WriteLine("\nHere's a list of some of your favorite movies.\n");

            string[] movies = { "Raiders", "Working Girl", "Octopussy", "A Little Romance", "The Fifth Element" };
            string[] vowels = { "a", "e", "i", "o", "u" };

            //foreach (string movie in movies) 
            //foreach(string vowel in vowels)   
            {
                //Console.WriteLine(movie);

                //for (int i = 0; i < movies.Length; i++)
                //{

                //}

                //foreach (string vowel in vowels)
                foreach (string movie in movies)

                    foreach (string vowel in vowels)
                        {

                        if (movie.StartsWith(vowel))
                        {
                            continue;
                        }

                        else
                        {
                            Console.WriteLine(movie);
                        }
                    }
            }
            //you're on the right track, but you need something like a bool in there. 
            //eh i keep getting different info.
            //the good news: Jackie tried the exact same thing, and got the same result I did


            //moving on...

            //ask a student for grades to calculate GPA

            Console.WriteLine("\nLet's calculate your GPA this semester.\n");

            bool hasMoreClasses = true;
            double gradeValue = 0;
            double gradeSum = 0;
            double numberOfClasses = 0;

            while (hasMoreClasses == true)
            {
                Console.WriteLine("Please enter one letter grade.");
                char letterGrade = char.Parse(Console.ReadLine());

                switch (letterGrade)
                {
                    case 'a':
                        gradeValue = 4.0;
                        break;
                    case 'b':
                        gradeValue = 3.0;
                        break;
                    case 'c':
                        gradeValue = 2.0;
                        break;
                    case 'd':
                        gradeValue = 1.0;
                        break;
                    default:
                        gradeValue = 0;
                        Console.WriteLine("Dummy!");
                        break;

                }

                Console.WriteLine($"That letter grade is a {gradeValue}.");
                numberOfClasses++;

                gradeSum += gradeValue; 

                Console.WriteLine("\nDo you have another grade to enter? yes/no");
                string userAnswer = Console.ReadLine();

                if (userAnswer == "yes")
                {
                    hasMoreClasses = true;
                }

                else if (userAnswer == "no")
                {
                    hasMoreClasses = false;
                }
            }

            double gradeAverage = gradeSum / numberOfClasses;
            Console.WriteLine($"Your GPA is {gradeAverage}.");

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
