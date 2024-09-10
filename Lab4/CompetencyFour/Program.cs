using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace LabFour
{
    class SecondProgram
    {
        static void Main(string[] args)
        {
            // 1. Add student name, course number, and CRN as a multi-line comment at the beginning of your code.

            /* Cornell Burts, IT 1050, & 86411 */

            // 2. In a comment, compare and contrast the if (single-selection) statement and while loop. How are the statements similar? How are they different?

            /* The "if" statement and "while" loop are similar in that both evaluate a condition and, if the condition is true, execute a block of code.
            However, they differ in behavior and usage. The "if" statement is a single-selection control structure that runs its code block once if the condition is true.
            Additionally, "if" can be extended with "else if" and "else" branches to handle multiple conditions and provide fallback logic.

            In contrast, a "while" loop continuously checks its condition and repeatedly executes the code block as long as the condition remains true, allowing for repetition.
            Unlike "if" statements, "while" loops run multiple times, potentially leading to an infinite loop if the condition never becomes false. */

            // 3. Use a while loop to output values 48 to 92 on one line with one space between the values. Increment by 4. Note: 48 and 92 are inclusive.

            int i = 48;
            while (i <= 92)
            {
                Console.Write(i + " ");
                i += 4;
            }
            Console.WriteLine();

            // 4. Use a while loop to output values 98 to 21 on one line with one space between the values. Decrement by 7. Note: 98 and 21 are inclusive.

            int a = 98;
            while (a >= 21)
            {
                Console.Write(a + " ");
                a -= 7;
            }
            Console.WriteLine();

            // 5. Use a for loop to output values 61 to 72 on one line with one space between the values. Increment by 1. Note: 61 and 72 are inclusive.

            for (int b=61; b<=72; b++)
            {
                Console.Write(b + " ");
            }
            Console.WriteLine();

            // 6. Use a for loop to loop from 1-100. Each time through the loop, output the loop control variable and whether or not it is even or odd. Output on separate lines

            for (int c = 1; c<=100; c++)
            {
                if ((c % 2 == 0))
                {
                    Console.WriteLine(c + " is even");
                }
                else
                {
                    Console.WriteLine(c + " is odd");
                }
            }

            // 7. Use a while loop. Allow a user to input a value. Convert the input to an integer. If the input user enters equals 8, end the loop. Otherwise, keep asking for input.
            Console.WriteLine("Enter an even integer lower than 20");
            int y = Convert.ToInt32(Console.ReadLine());
            while (y != 8)
            {
                if(y == 8)
                {
                    Console.WriteLine("Very nice, first try!");
                    break;
                }
                else
                {
                    Console.WriteLine("Try again");
                    y = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Proud of your resilience, you have guessed the correct number");

            // 8. Use a for loop to output the sum of odd integers from 1 to 50.


            // 9. Use a while loop to output the following – 5 rows with 10 asterisks on each line


        }
    }
}
