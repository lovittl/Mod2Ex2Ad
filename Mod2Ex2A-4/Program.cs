using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Average a non-specific number of scores
Create a console application that will accept a number test scores 
(as calculated by the number of scores actually entered) 
between 0 and 100, average them, and report a letter grade for the average 
based on the usual scale. For example, a teacher will input any number test scores, 
and see the average numerical grade and the letter grade.
*/
namespace Mod2Ex2A_4
{
    class Program
    {
        static void Main(string[] args)

        {   // declare values to hold test values and perform calculation
            int i=0, n=0, sum = 0;
            double avg;

            //ellicit input
            Console.Write("\n\n");
            //Console.Write("Enter scores and enter 999 to quit:");
            Console.Write("Enter scores between 0 and 100 and 999 when finished:\n");
            Console.Write("----------------------------------------------");
            Console.Write("\n\n");

            //collects the number of scores to be input
            //Console.Write("Input the scores : \n");

            //collect the scores and adds them up to be used in the avg calculation
            
            while (n != 999)

            {
                i++;
                Console.Write("Number-{0} :", i);
                n = Convert.ToInt32(Console.ReadLine());
                
                if (n != 999)
                {
                    sum += n;
                }
                else
                {
                    sum = sum;
                }
            }
            avg = sum / (i - 1);

            ////collects the scores and adds them up to be used in the avg calculation
            //for (i = 1; i <= ns; i++)
            //{
            //    Console.Write("Number-{0} :", i);

            //    n = Convert.ToInt32(Console.ReadLine());
            //    sum += n;
            //}
            //calculate average and assign to variable avg
            //avg = sum / (i - 1);

            Console.Write("\nThe Average is : {0}\n", avg);
            Console.WriteLine("Your letter grade is : {0}\n", (GetGrade(avg)));
        }
        //assigns a letter grade based on numerical value
        static char GetGrade(double LetGrade)
        {
            int avg = 0;
            char let;

            if (avg >= 90 && avg <= 100)
            {
                let = 'A';
            }
            else if (avg >= 80 && avg <= 89)
            {
                let = 'B';
            }
            else if (avg >= 70 && avg <= 79)
            {
                let = 'C';
            }
            else if (avg >= 60 && avg <= 69)
            {
                let = 'D';
            }
            else if (avg >= 0 && avg <= 59)
            {
                let = 'F';
            }
            else
            {
                Console.WriteLine("numbers entered out of bounds");
                return 'x';
            }

            return let;
        }
    }
}
