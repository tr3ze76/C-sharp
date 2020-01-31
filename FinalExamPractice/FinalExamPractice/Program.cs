using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExamPractice
{
    class Program
    {
        static void Main(string[] args)
        {

            int val1 = 10;
            int val2 = 1000;
            int val3 = 200;
            float quiz = 80;
            float midscore = 70;
            float final = 100;
            




            Console.WriteLine("Hello {ALBERTO}!");

            SolutionProblem1(val1, val2, val3);
            SolutionProblem2(quiz, midscore, final);
            SolutionProblem3(575757);
            SolutionProblem4();
            SolutionProblem5("juju" );


            //CALL YOUR FUNTIONS HERE

            //ALWAYS USE READKEY TO KEEP THE CONSOLE OPEN

            Console.ReadKey();

        }



        static void SolutionProblem1(int val1, int val2, int val3)
        {
            try
            {
                int greatestValue = 0;

                if (val1 >= val2 && val1 >= val3)
                {
                    greatestValue = val1;
                }
                if (val2 >= val3 && val2 >= val1)
                {
                    greatestValue = val2;
                }
                if (val3 >= val1 && val3 >= val2)
                {
                    greatestValue = val3;
                }



                Console.WriteLine(greatestValue.ToString() + " is the largest.");


            }
            catch (Exception ex)
            {
                Console.WriteLine("An error ocurred");
            }




        }
        static void SolutionProblem2(float quiz, float midscore, float final)
        {
            try
            {
                string Grade = "";
                float average = ((quiz + midscore + final) / 3);

                if (average >= 90 && average < 100)
                {
                    Grade = "A";
                }
                if (average >= 70 && average < 90)
                {
                    Grade = "B";
                }
                if (average >= 50 && average < 70)
                {
                    Grade = "C";
                }
                if (average > 50) ;
                {
                    Grade = "F";
                }

                Console.WriteLine(Grade + " the Grade is");


            }
            catch (Exception ex)
            {
                Console.WriteLine("an error ocurred");
            }




        }
        static void SolutionProblem3(int number)
        {
            try
            {


                string numbertext = number.ToString();



                Console.WriteLine("number of digits " + numbertext.Length);




            }
            catch (Exception ex)
            {
                Console.WriteLine("an error ocurred");
            }
        }

        static void SolutionProblem4()
        {
            for (int val1 = 33; val1 <= 175; val1++)
            {
                Console.Write(" " + val1 + " = " + (char)val1 + " ");
                if (val1 % 10 == 0)
                {
                    Console.WriteLine();
                }
            }

            Console.WriteLine();

        }

        static void SolutionProblem5(string val1)
        {
            try
            {
                String Text = "";
                Text = val1.ToString();


                Console.WriteLine(" number of spaces " + Text.Length);
            }
            catch
            {
                
            }



        }





        
    }
}
