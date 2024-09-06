
using System;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
namespace LabThree
{
    class Program
    {
        static void Main(string[] args)
        {
        // 1. Add student name, course number, and CRN as a multi-line comment at the beginning of your code.

        /* Cornell Burts IT 1050 and 86411
         */

        // 2. Use an if statement. Given the variables temp = 72 and tempLimit = 38, output "WARM WEATHER!" if temp is greater than tempLimit.

        int temp = 72;
        int tempLimit = 38;
        if (temp>tempLimit)
        {
            Console.WriteLine("WARM WEATHER!");
        }

        // 3. Given the variables x = 47 and y = 68, use an if statement to compare the two variables and output a statement that states which variable is smaller.

        int x = 47;
        int y =68;
        if (x<y)
        {
            Console.WriteLine("x is the smaller variable");
        }

        // 4. Use an if-else statement. If isOver16 is true, output "The student can learn to drive." If isOver16 is false, output "The student cannot learn to drive."

        bool isOver16 = true;
        if (isOver16)
        {
            Console.WriteLine("The student can learn to drive!");
        }
        else {
            Console.WriteLine("The student cannot learn to drive :(");
        }

        // 5. Use an if-else statement to display “Passed” if a student’s score on the learner’s permit test is greater than or equal to 75 but displays “Failed” if it’s less than 75. Include an encouraging message to the student that failed and a congratulatory message to the student that passed.

        int pass = 96;
        int fail = 75;
        if (pass >= fail)
        {
            Console.WriteLine("Passed!");
            Console.WriteLine("Congratulations on completing the learner's permit test. Drive safe and focus on the road at all times!");
        }
        else {
            Console.WriteLine("You will get it next time! When studying, make sure focus on the questions that confused you. I believe you'll pass after doing that!!  ");
        }

        // 6. Use an if-else if-else statement. Print a letter grade for the following conditions:

        int grade = 95;
        if (grade >= 90)
        {
            Console.WriteLine("A");
        }
        else if (grade >= 80)
        {
            Console.WriteLine("B");
        }
        else if (grade >=70)
        {
            Console.WriteLine("C");
        }
        else if (grade >= 60)
        {
            Console.WriteLine("D");
        }
        else {
            Console.WriteLine("F");
        }

        // 7. Use an if-else if-else statement. Display a prompt to the user to choose a number between 1 and 5 (1 and 5 are inclusive) and then store the user’s input in a string variable. Display a message to the user that tells them the prize they have won. The prizes are as follows:

        Console.WriteLine("Pick a number between 1 and 5");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number == 1)
        {
            Console.WriteLine("You won a computer");
        }
        else if (number == 2)
        {
            Console.WriteLine("You won a monitor");
        }
        else if (number == 3)
        {
            Console.WriteLine("You won a mouse");

        }
        else if (number == 4)
        {
            Console.WriteLine("You won a keyboard");
        }
        else if (number == 5)
        {
            Console.WriteLine("You won a printer");
        }
        else {
            Console.WriteLine("You lose. Try again!");
        }

        // 8. Use a switch statement to output the following values for sport course level description.

        int level = 6;
        switch(level)
        {
            case 1:
                Console.WriteLine("Recreational");
                break;
            case 2:
                Console.WriteLine("Lower Intermediate");
                break;
            case 3:
                Console.WriteLine("Intermediate");
                break;
            case 4:
                Console.WriteLine("Upper Intermediate");
                break;
            case 5:
                Console.WriteLine("Competitive");
                break;
            case 6:
                Console.WriteLine("Very Competitive");
                break;
            case 7:
                Console.WriteLine("Highest level of Competition");
                break;
        }

        // 9. Use a switch statement to determine if the number 729 is odd or even and output a message stating whether 729 is odd or even

        int num = 729;
        switch (num % 2)
        {
            case 0:
                Console.WriteLine("An even number");
                break;
            case 1:
                Console.WriteLine("An odd number");
                break;

        }
        }
    }
}
