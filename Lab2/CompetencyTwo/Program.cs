
using System;
using System.Runtime.CompilerServices;
namespace LabOne
{
    class Program
    {
        static void Main(string[] args)
        {
        /* Add your name, course number, and CRN as a multi-line comment at the beginning of your code.*/

        /* Cornell Burts, IT 1050, 86411 */

        /* Create 5 integer variables u, v, w, x, and y. Assign values to each of them. Output the sum: u + v + w + x + y. */
        int u = 3;
        int v = 9;
        int w = 27;
        int x = 81;
        int y = 243;
        Console.WriteLine(u + v + w + x +y);

        /* Create a variable called name. Assign your name to it. Create a variable called major. Assign your major to the variable called major. Use string interpolation ($) to Output: [Your name]'s major is [major]. Example: student named John Smith whose major is Programming will output John's major is programming.*/
        string name = "Cornell";
        string major = "Computer Science";
        Console.WriteLine($"{name} is majoring in {major} " );

        /* Use the following given code Console.Write("Please enter the price: "); to prompt a user to enter a value in the console. Use the code string inputstr = Console.ReadLine( ); to read in a variable (whole numbers only) from the console. Then convert the variable inputstr to an integer value and assign it to an int variable called inputint. Then multiply inputint by 1.08 and output "The total price with tax is " + inputint (use the concatenation operator +). */
        Console.Write("Please enter the price: ");
        string inputStr = Console.ReadLine();
        int inputInt = Convert.ToInt16(inputStr);
        double withTax = inputInt * 1.08;
        Console.Write("The total price with tax is " + withTax);
        /* Use the increment operator to increment to add 1 to the number below and output the result. */
        int number = 4358;
        int numbers = number++;
        Console.WriteLine(numbers);

        /* Create a string variable called season and assign your favorite season to it. Concatenate it to the following string using string interpolation($) and output the value. */
        string season = "Winter";
        string favSeason = "My favorite season is ";
        Console.WriteLine(favSeason + season);

        /* Output the following programming language variables separated by commas using the string concatenation operator(+). Your output will be C#, HTML, CSS, Python, Java */
        string lang1 = "C#";
        string lang2 = "HTML";
        string lang3 = "CSS";
        string lang4 = "Python";
        string lang5 = "Java";
        Console.WriteLine(lang1 + ", " + lang2 + ", " + lang3 + ", " + lang4 + ", " + lang5);

        /* Divide the following variable by 100 and output the value. */
        double num = 84.26D;
        double divide = 100;
        Console.WriteLine(num / divide);

        /* Add the two values together and output the sum. */
        int operand1 = 357;
        int operand2 = 119;
        Console.WriteLine(operand1 + operand2);

        /* Evaluate the expression d * m + (s * 3) + 4 * m using the given values for d, m, and s. Output the value. */
        double d = 1.8D;
        double m = 2.3D;
        double s = 12.2D;
        Console.WriteLine(d * m + (s*3) + 4 * m);

        /* Convert the address to all uppercase and output the value using a single Console.WriteLine() statement and the newline escape sequence, so each variable is on a separate line */
        string addr1 = "11000 W Pleasant Valley Road";
        string addr2 = "Parma,Oh";
        string addr3 = "44130";
        Console.WriteLine(addr1.ToUpper() + "\n" + addr2.ToUpper() + "\n"  + addr3.ToUpper());
        }
    }
}
