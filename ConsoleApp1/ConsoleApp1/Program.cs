using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {



        static void Main(string[] args)
        {

            int result = 1;

            Console.WriteLine("Hello Uber");
            int[] arrInput = { 1, 2, 3, };
            int[] arrOutput = new int[arrInput.Length];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i != j)
                    {
                        Console.WriteLine(arrInput[j]);
                        result = (arrInput[j] * result);
                    }

                }
                arrOutput[i] = result;
                result = 1;

                Console.WriteLine(result);
            }
            for (int x = 0; x < 3; x++)



                Console.ReadKey();





        }

    }
}
