// See https://aka.ms/new-console-template for more information

using TestConsoleApp.TechnicalTests;

Console.WriteLine("Hello, World!");
Console.WriteLine("What would you like to do?");
Console.WriteLine("Please type one of the following codes");
Console.WriteLine("");

Console.WriteLine("Say Hi = 0");
Console.WriteLine("Reverse String = 1");
Console.WriteLine("Remove String Chars = 2");
Console.WriteLine("Fizz Pop Buzz = 3");
Console.WriteLine("Phoebus Test = 4");
Console.WriteLine("Show Prime Numbers 1-100 = 5");

Console.WriteLine("");

string? input = Console.ReadLine()?.ToLower();

if (input == null)
{
    Console.WriteLine("No input detected");
    return;
}
else if (!int.TryParse(input, out int _input))
{
    Console.WriteLine("Input must be an integer");
    return;
}
else
{
    StringOperations stringOperations = new StringOperations();

    switch (_input)
    {
        case 0:
            Console.WriteLine("Hi");
            break;
        case 1:
            // Reverse string
            string reversedString = stringOperations.ReverseString("Hello World");
            Console.WriteLine("");
            Console.WriteLine("String Reversed:");
            Console.WriteLine(reversedString);
            break;
        case 2:
            // Remove chars from string
            string stringToRemoveFrom = "The fox jumped over the wall";
            string charsToRemove = "aeiou";
            string newString = stringOperations.RemoveStringChars(stringToRemoveFrom, charsToRemove.ToCharArray());
            Console.WriteLine("");
            Console.WriteLine("Chars Removed:");
            Console.WriteLine(newString);
            break;
        case 3:
            // Write a program that prints the numbers from 1 to 100 and for;
            // multiples of ‘3’ print “Fizz” instead of the number
            // multiples of ‘5’ print “Buzz” instead of the number 
            // multiples of ‘5’ and '3' print “Pop” instead of the number 
            MathmaticalOperations mathmaticalOperations = new MathmaticalOperations();
            mathmaticalOperations.FizzPopBuzz();
            break;
        case 4:
            // Phoebus - Software developer task
            int sundayCount = 0;

            Dictionary<int, string> days = new Dictionary<int, string>();
            days.Add(0, "Monday");
            days.Add(1, "Tuesday");
            days.Add(2, "Wednesday");
            days.Add(3, "Thursday");
            days.Add(4, "Friday");
            days.Add(5, "Saturday");
            days.Add(6, "Sunday");

            Dictionary<string, int> months = new Dictionary<string, int>();
            months.Add("January", 31);
            months.Add("February", 28);
            months.Add("March", 31);
            months.Add("April", 30);
            months.Add("May", 31);
            months.Add("June", 30);
            months.Add("July", 31);
            months.Add("August", 31);
            months.Add("September", 30);
            months.Add("October", 31);
            months.Add("November", 30);
            months.Add("December", 31);

            int startingYear = 1900;
            int endingYear = 2000;
            for (int i = startingYear; i <= endingYear; i++)
            {
                Console.WriteLine("Year: " + i);
                Console.WriteLine("Yearly Sunday Count: " + sundayCount);

                // Check it is a leap year first
                bool isLeapYear = false;
                if ((i % 100) == 0)
                {
                    if ((i % 400) == 0)
                    {
                        isLeapYear = true;
                    }
                }
                else if ((i % 4) == 0)
                {
                    isLeapYear = true;
                }

                if (isLeapYear)
                {
                    var feb = months["February"];
                    feb = 29;
                }

                // We only want to count from '1 Jan 1901 to 31 Dec 2000'
                if (i > 1900)
                {
                    int d = 0;

                    // Loop through each month and day
                    foreach (var month in months)
                    {
                        //Console.WriteLine("Month: " + month.Key);

                        int noOfDays = month.Value;

                        for (int j = 1; j <= noOfDays; j++)
                        {
                            // Reset the week day
                            if (d > 6)
                            {
                                d = 0;
                            }

                            //Console.WriteLine("Day: " + j.ToString() + days[d].ToString());

                            if (days[d].ToString().ToLower() == "sunday")
                            {
                                sundayCount++;
                            }

                            d++;
                        }
                    }
                }
            }

            Console.WriteLine("Sunday Count: " + sundayCount);
            break;
        case 5:
            // Check for Prime Numbers


            break;
    }


    return;
}






// Stuff to add..

// Variables
// Key Words
// Operators
// Classes
// Constructors
// Inheritance
// Design Patterns
// Abstract
// Interfaces
// Sessions
// Statics
// Unit Tests - in progress
// Software Tests - in progress
// Remove certain chars from string - done
// Fizz Pop Buzz test - done



// Methods with User Inputs
// Not needed for tests. For future reference.

//case 1:
//            while (true)
//{
//    Console.WriteLine("Enter the string you want to reverse");
//    string? reverseMe = Console.ReadLine();

//    if (reverseMe == null && string.IsNullOrWhiteSpace(reverseMe))
//    {
//        Console.WriteLine("No string detected");
//        Console.WriteLine("");
//    }
//    else
//    {
//        string reversedString = stringOperations.ReverseString(reverseMe);
//        Console.WriteLine("");
//        Console.WriteLine("String Reversed:");
//        Console.WriteLine(reversedString);
//        break;
//    }
//}
//break;

//case 2:
//            while (true)
//{
//    Console.WriteLine("Enter the starting string");
//    string? removeFromMe = Console.ReadLine();

//    if (removeFromMe == null || string.IsNullOrWhiteSpace(removeFromMe))
//    {
//        Console.WriteLine("No string detected");
//        Console.WriteLine("");
//    }
//    else
//    {
//        while (true)
//        {
//            Console.WriteLine("Enter the chars to remove");
//            string? charsToRemove = Console.ReadLine();

//            if (charsToRemove == null || string.IsNullOrWhiteSpace(charsToRemove))
//            {
//                Console.WriteLine("No chars detected");
//                Console.WriteLine("");
//            }
//            else
//            {
//                string newString = stringOperations.RemoveStringChars(removeFromMe, charsToRemove.ToCharArray());

//                Console.WriteLine("");
//                Console.WriteLine("Chars Removed:");
//                Console.WriteLine(newString);

//                break;
//            }
//        }
//        break;
//    }
//}
//break;