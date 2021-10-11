using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionThree
{
    class Program
    {
        static void Main(string[] args)
        {
            //Asking user for number of values, for array
            Console.Write("Enter Number of Values: ");
            //Taking in input of number of values, to create array bounds
            int NumVals = Convert.ToInt32(Console.ReadLine());

            //Declaring float array
            float[] arrNumbers = new float[NumVals];
            
            //Declaring for loop
            for (int x = 0; x < NumVals; x++)
            {
                //Asking for input numbers into array
                Console.Write("Enter Number " + (x + 1) + ": ");
                //Assigning input into array
                arrNumbers[x] = float.Parse(Console.ReadLine());
            }

            //Clears the console
            Console.Clear();

            //Displaying the headers of numbers
            Console.WriteLine("Entered Numbers:");
            for (int i = 0; i < NumVals; i++)
            {
                Console.Write(i + "\t");
            }

            //Leaves a line
            Console.WriteLine();

            //Displaying the numbers in the arrays
            for (int i = 0; i < NumVals; i++)
            {
                Console.Write(arrNumbers[i] + "\t");
            }

            Console.WriteLine();
            Console.WriteLine();

            //Displaying heading
            Console.WriteLine("Reversed Numbers");
            //Calling the function to reverse array
            Reverse(arrNumbers, NumVals);

            Console.Read();

        }

        //Function, with array and variable as parameters
        public static void Reverse(float[] FloatArrNum, int y)
        {
            //Declaration of variable
            int i = 0;
            int j = FloatArrNum.Length - 1;//length of array - 1

            //Declaration of while loop
            while (i < j)
            {
                //assigning the temp variable with the position at i
                var temp = FloatArrNum[i];
                //assigning the array position of i with array position j
                FloatArrNum[i] = FloatArrNum[j];
                //assigning array position j with the temp variable
                FloatArrNum[j] = temp;
                //increasing counter i by 1
                i++;
                //decreasing counter j by 1
                j--;
            }//end of while loop

            //Declaration of for loop -  display number of values
            for (int dis = 0; dis < y; dis++)
            {
                Console.Write(dis + "\t");
            }

            //New line
            Console.WriteLine();

            //for loop - Displaying the reversed array
            for (int dis = 0; dis < y; dis++)
            {
                Console.Write(FloatArrNum[dis] + "\t");
            }

        }
    }
}
