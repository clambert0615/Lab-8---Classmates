using System;
using System.Globalization;

namespace Lab_8___Get_to_Know_Your_Classmates
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] studentNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            string[] students = { "Amy", "Andrew", "Brett", "Bob", "Dave", "Debi", "Jill", "Joe", "Jack", "Mark", "Mary", "Paul", "Sara", "Steve", "Tim" };
            string[] hometowns = { "Detroit", "Macomb", "Rochester", "Utica", "Novi", "Chesterfield", "New Baltimore", "Royal Oak", "Ferndale", "Clawson", "Fraser", "Roseville", "Eastpointe", "Sterling Heights", "Clinton Township" };
            string[] favoriteFoods = { "pizza", "ice cream", "apples", "bananas", "steak", "chicken", "eggs", "bacon", "french fries", "pork chops", "potatoes", "corn", "peas", "rice", "carrots" };
            int[] ages = { 10, 12, 14, 11, 13, 10, 11, 13, 10, 14, 11, 12, 13, 15, 15 };

            int numberToMatch;
            bool keepAsking = true;
            int studentNumber;
            string nameInput;
            int nameIndex;

            while(keepAsking)
            {
                Console.WriteLine("Would you like to search for students by number or name?");
                string input = Console.ReadLine().ToLower().Trim();

                if (input == "name")
                {
                    try
                    {
                        Console.WriteLine("Enter student's name with a capital letter followed by lowercase letters");
                        nameInput = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(Console.ReadLine());
                        nameIndex = Array.IndexOf(students, nameInput);
                        studentNumber = studentNumbers[nameIndex];
                        numberToMatch = studentNumbers[studentNumber - 1] - 1;
                        keepAsking = false;
                    }
                    catch(IndexOutOfRangeException)
                    {
                        Console.WriteLine("Invalid name.  Please try again");
                        continue;
                    }
                }
                else if (input == "number")
                {
                    Console.WriteLine("Which student would you like to learn more about?  Enter a number between 1 and 15.");

                    try
                    {
                        studentNumber = int.Parse(Console.ReadLine());
                        numberToMatch = studentNumbers[studentNumber - 1] - 1;
                        keepAsking = false;
                    }
                    catch (IndexOutOfRangeException)
                    {
                        Console.WriteLine("Invalid number, enter a number between 1-15");
                        continue;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("This is not a number. Try again!");
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input.  Try again");
                    continue;
                }

                string matchStudenttoName = students[numberToMatch];
                string matchStudenttoFood = favoriteFoods[numberToMatch];
                string matchStudenttoHometown = hometowns[numberToMatch];
                int matchStudenttoAge = ages[numberToMatch];

                keepAsking = true;

                Console.WriteLine($"Student {studentNumber} is {matchStudenttoName}.");
                Console.WriteLine($"What would you like to know about {matchStudenttoName}? enter \"hometown\" or \"favorite food\" or \"age\"");
                string input2 = Console.ReadLine().ToLower().Trim();
                if (input2 == "hometown")
                {
                    Console.WriteLine($"{matchStudenttoName} is from {matchStudenttoHometown}.");
                }
                else if (input2 == "favorite food")
                {
                    Console.WriteLine($"{matchStudenttoName}'s favorite food is {matchStudenttoFood}.");
                }
                else if (input2 == "age")
                {
                    Console.WriteLine($"{matchStudenttoName} is {matchStudenttoAge}");
                }
                else
                {
                    Console.WriteLine("Invalid input. Try again");
                    continue;
                }
                   

            }
                
                
                bool askAgain = true;
                while (askAgain)
                {
                    Console.WriteLine("Would you like to ask about another student? Enter \"y\" or \"n\"");
                    string decision = Console.ReadLine().ToLower().Trim();

                    if (decision == "y")
                    {
                        askAgain = false;
                        keepAsking = true;
                    }
                    else if (decision == "n")
                    {
                        askAgain = false;
                        keepAsking = false;
                        Console.WriteLine("Exiting. Goodbye!");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input.  Try again");
                        continue;
                    }
                    


                }
            

        }
            
    }
}
