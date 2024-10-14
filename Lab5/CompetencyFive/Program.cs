using System;
using System.Runtime;

namespace CompetencyFive
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Add name, course number, and CRN as a multi-line comment at the beginning of the code.
            /* Cornell Burts, IT 1050, 86411 */

            //2. Create a string array to store the names of popular websites: Google, YouTube, Facebook, Instagram, Yahoo!, Baidu, TikTok and Reddit.
            string [] websites = {"Google", "Youtube", "Facebook", "Instagram", "Yahoo!", "Baidu", "TikTok", "Reddit"};
            for (int i =0;i<websites.Length;i++){
                Console.WriteLine(websites[i]);
            }
            Console.WriteLine();

            //3. Create a double array for prices. Name the array Prices.
            double [] prices = {4.63, 9.08, 32.92, 14.03, 32.34, 8.13, 3.25, 8.62};
                double sumOfPrices = 0;
                double taxOfPrices = 0;
                foreach (double i in prices) {
                sumOfPrices += i;
                taxOfPrices = sumOfPrices * 1.08;
                }
                Console.WriteLine("The sum is " + sumOfPrices);
                Console.WriteLine("With tax " + taxOfPrices);

            Console.WriteLine();

            //4. Create parallel arrays for the following student names and test scores.
            string [] students = {"Gabby", "John", "Sara", "Frank", "Ben", "Wendy", "Mike", "Ava"};
            int [] scores = {95, 62, 87, 74, 83, 59, 78, 91};
            for (int a = 0; a <scores.Length; a++){
                Console.WriteLine($"{students[a]} {scores[a]}");
            }
            Console.WriteLine();

            //5. Create a 12-element array to store months of the year. Name for the array is Months. Set each element to the name of each month. Use a for loop to display the number and name of each month on separate lines with one space between the month number and month name on each line.
            string [] months = {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"};
            int [] dayOfMonth = {1,2,3,4,5,6,7,8,9,10,11,12};
                for (int b=0; b<dayOfMonth.Length; b++) {
                    Console.WriteLine($"{dayOfMonth[b]} {months[b]}");
                }
                Console.WriteLine();

            //6. Create a two-dimensional array to store the following states and their capitals and use a for loop to output each state and its capital on a separate line with spaces between the state and its capital.

            string [,] statesAndCapitals = {{"Connecticut","Hartford"}, {"Delaware","Dover"}, {"Kentucky", "Frankfort"}, {"Maryland", "Annapolis"}, {"Massachusetts", "Boston"}, {"Michigan","Lansing"}, {"New Hampshire", "Concord"}, {"New Jersey", "Trenton"}, {"New York", "Albany"}, {"North Carolina", "Raleigh"}, {"Pennsylvania", "Harrisburg"}, {"Rhode Island", "Providence"}, {"South Carolina", "Columbia"}, {"Tennessee", "Nashville"}, {"Virginia", "Richmond"}, {"West Virginia", "Charleston"} };
            for(int i = 0; i<statesAndCapitals.GetLength(0);i++){
                Console.WriteLine(statesAndCapitals[i,0] + " " + statesAndCapitals[i,1]);
            };
            Console.WriteLine();

            //7. Given the following array named Sample
            int[] sample = {24,58,63,75,92,21,80};
            Console.WriteLine(sample.Sum());
            Console.WriteLine(sample.Min());
            Console.WriteLine(sample.Max());
            Console.WriteLine(sample.Average());
            Console.WriteLine(sample.Count());
            Array.Sort(sample);
            foreach (int i in sample)
            {
                Console.Write(i+ " ");
            }
            Console.WriteLine();

            //8. Create a char array to store the first 10 letters of the English Alphabet in uppercase. Use an appropriate name for the array. Use a for loop to print the uppercase letters on one line with a space between the letters.
            Console.WriteLine();
            char [] alphabet = {'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J'};
            for(int n =0 ;n<alphabet.Length;n++){
            Console.Write(alphabet[n] + " ");
            }
            Console.WriteLine();

            //9. Create a double array of the following decimal numbers 13.97, 34.43, 21.87, 22.93, 19.32, 19.92, 11.30, 30.45 and name the array Numbers.
            Console.WriteLine();
            double [] numbers = {13.97,34.43,21.87,22.93,19.32,19.92,11.30,30.45};
            double totalOfNumbers = 0;
            foreach (double i in numbers){
                totalOfNumbers += i;
            }
            Console.WriteLine("The sum is " + totalOfNumbers);
            Array.Sort(numbers);
            foreach (double i in numbers)
            {
                Console.Write(i+ " ");
            }
        }
    }
}
