//Author: Jean Bryant Figueroa
//Course: COMP003A
//Faculty: Johnathan Cruz
//Purpose: A program demonstrating statements, varibles, and operators

namespace COMP003A.LectureActivity2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName; //store name as a string
            int userAge; //store age as an number
            double productPrice; //store the product price
            bool isStudent; //true / false statement

            Console.Write("Enter your name: "); //name prompt
            userName = Console.ReadLine(); //assign input

            Console.Write("Enter your age: "); //age prompt
            userAge = int.Parse(Console.ReadLine()); //assign input

            Console.Write("Enter the price of a product: "); //price prompt
            productPrice = double.Parse(Console.ReadLine()); //assign input

            Console.Write("Are you a student? (true/false): "); //student prompt
            isStudent = bool.Parse(Console.ReadLine()); //assign input

            int futureAge = userAge + 5; //adds 5 to user age
            bool isAdult = userAge >= 18; //checks if adult
            bool isAdultStudent = isStudent && isAdult; //checks if both student and adult

            Console.WriteLine($"\nHello {userName}!"); //displays name
            Console.WriteLine($"You are currently {userAge} years old. In five years you will be {futureAge}."); //displays current and future age
            Console.WriteLine($"Are you 18 or older {isAdult}"); //displays if adult
            Console.WriteLine($"Are you both a student and 18 or older? {isAdultStudent}"); //displays if adult and student
        }
    }
}
