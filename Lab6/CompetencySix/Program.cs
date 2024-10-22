using System;

namespace MyNamespace
{
    class Program
    {
        // 1. Add name, course number, and CRN as a multi-line comment at the beginning of the code.
            /* Cornell Burts, IT 1050, 86411 */
        public static void Main(string[] args)
        {
            Student student1 = new Student(); // 7. Create an object called student1.
            Console.WriteLine(student1.name); // 8. Output the value of the name property (student1.name) inside of a Console.WriteLine().
            // Console.WriteLine(student1.name)
            Console.WriteLine(student1.getMajor()); // 9. Output the return value from student1.getMajor()

            // student1.getMajor()
            Console.WriteLine(student1.getCourse()); // 10.Output the return value from student1.getCourse().
            // student1.getCourse()
            student1.printName(); // 11.Call printName() to output name again.
            }
        }
    class Student // 2. Create a class named Student.
    {
        public string name= "Cornell"; // 3. Add a property called name. Assign your name to the name property.
        public string major = "Computer Science";
        public string course = "IT 1050: Programming Logic";

        public string getMajor() // 4. Add a method called getMajor(). Have it return the major you are currently pursuing at Tri-C
        {
            return major;
        }
        public string getCourse() // 5. Add a method called getCourse(). Have it return our course number and course title as listed on the syllabus.
        {
            return course;
        }
        public void printName() // 6. Add a method called printName. It should not return any values. In the body of the method, add the following line: Console.WriteLine(this.name);
        {
            Console.WriteLine(this.name);
        }
    }
}
