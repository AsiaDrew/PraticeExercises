public class Program
{
    public static void Main()
    {
        //ExericiseOneStringInput();
        //ExerciseTwoIntegerInput();
        //ExerciseThreeIntegerInput();
        //ExerciseFourAddTwoIntgers();
        //ExerciseFiveMultipyTwoIntegers();
        //ExerciseSixDoWhileLoopContinueYorN();
        //ExerciseSevenKindOfLikeExerciseSix();
        //ExerciseEightIsExereciseTwoToThreeInALoop();
        //ExerciseNineSwitchStatement();
        //ExerciseTen();
        //ExerciseEleven();

        ExerciseTwelve();
    }

    private static void ExerciseTwelve()
    {
        //EXERCISE 12
        //Output all the numbers from 9 to 0. Use a for loop to output all the numbers from 9 to 0.
        bool continueQuestion = true;
        while (continueQuestion)
        {
            List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            List<int> reverse = Enumerable.Reverse(numbers).ToList();

            Console.WriteLine(String.Join(',', reverse));
            // Console.WriteLine($"Numbers: {numbers[i]}");
            Console.WriteLine("Would you like to try again? y/n");
            string continueResponse = Console.ReadLine().ToLower();
            if (continueResponse == "yes" || continueResponse == "y")
            {
                continueQuestion = true;
                Console.WriteLine();
                continue;
            }
            else if (continueResponse == "no" || continueResponse == "n")
            {
                continueQuestion = false;
                Console.WriteLine("Ok, Bye!");
                break;
            }
            else
            {
                Console.WriteLine("Sorry input was not valid. Please try again later. Goodbye!");
                continueQuestion = false;
                break;
            }
        }
    }

    private static void ExerciseEleven()
    {
        //EXERCISE 11
        //Use a for loop to output all the numbers from 0 to 9.
        bool continueQuestion = true;
        while (continueQuestion)
        {
           // List<int> list = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Numbers: {numbers[i]}");
            }
            Console.WriteLine("Would you like to try again? y/n");
            string continueResponse = Console.ReadLine().ToLower();
            if (continueResponse == "yes" || continueResponse == "y")
            {
                continueQuestion = true;
                Console.WriteLine();
                continue;
            }
            else if (continueResponse == "no" || continueResponse == "n")
            {
                continueQuestion = false;
                Console.WriteLine("Ok, Bye!");
                break;
            }
            else
            {
                Console.WriteLine("Sorry input was not valid. Please try again later. Goodbye!");
                continueQuestion = false;
                break;
            }
        }
    }

    private static void ExerciseTen()
    {
        //EXERCISE 10
        bool continueQuestion = true;
        while (continueQuestion)
        {

            Console.WriteLine("Enter your height in inches: ");
            decimal inputInches = decimal.Parse(Console.ReadLine());
            decimal theDifference = Math.Round(54 - inputInches);

            if (inputInches >= 54)
            {
                Console.WriteLine("Great, you can ride the Raptor!");
            }
            else
            {
                Console.WriteLine($"Sorry, you cannot ride the Raptor. You need to be taller by {theDifference} more inches.");
            }
            Console.WriteLine("Would you like to try again? y/n");
            string continueResponse = Console.ReadLine().ToLower();
            if (continueResponse == "yes" || continueResponse == "y")
            {
                continueQuestion = true;
                Console.WriteLine();
                Console.WriteLine("Ok Good!");
                continue;
            }
            else if (continueResponse == "no" || continueResponse == "n")
            {
                continueQuestion = false;
                Console.WriteLine("Ok, Bye!");
                break;
            }
            else
            {
                Console.WriteLine("Sorry input was not valid. Please try again later. Goodbye!");
                continueQuestion = false;
                break;
            }
        }
    }

    private static void ExerciseNineSwitchStatement()
    {
        //Prompt the user to enter a language.
        //Based on the language the user input, display "Hello, World!" in that language.
        //Use a switch statement to choose what to display.
        bool shouldContinue;
        do
        {
            Console.WriteLine("**Exercise 9 Switch Statement**");
            Console.WriteLine("Pick a language,  \nEnter English, Spanish, " +
                "or Dutch to display a greeting.");
            string languages = Console.ReadLine().ToLower();
            switch (languages)
            {
                case "english":
                    Console.WriteLine(">>Hello, World!");
                    Console.WriteLine();
                    break;
                case "spanish":
                    Console.WriteLine(">>Hola Mundo!");
                    Console.WriteLine();
                    break;
                case "dutch":
                    Console.WriteLine(">>Hallo wereld!");
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine(">>I don't know that language..");
                    break;
            }
            Console.WriteLine("Would you like to continue (y / n) ?");
            string userInput = Console.ReadLine().ToLower();
            Console.WriteLine();
            if (userInput == "y")
            {
                shouldContinue = true;
            }
            else
            {
                Console.WriteLine("See Ya!");
                Console.WriteLine();
                shouldContinue = false;
            }
        } while (shouldContinue);
    }
    private static void ExerciseEightIsExereciseTwoToThreeInALoop()
    {
        //Make exercises 2 - 5 run in a loop. Use a do -while loop to run the code in a loop. 
        //Each time you run the code ask the user whether they would like to continue.
        bool shouldContinue;
        do
        {
            Console.WriteLine("**Exercise 8 Do While Loop Exercises 2-5**");
            Console.WriteLine();
            ExerciseTwoIntegerInput();
            Console.WriteLine();
            ExerciseThreeIntegerInput();
            Console.WriteLine();
            ExerciseFourAddTwoIntgers();
            Console.WriteLine();
            ExerciseFiveMultipyTwoIntegers();
            Console.WriteLine();
            Console.WriteLine("Would you like to continue (y / n) ?");
            string userInput = Console.ReadLine().ToLower();
            Console.WriteLine();
            if (userInput == "y")
            {
                shouldContinue = true;
            }
            else
            {
                Console.WriteLine("See Ya!");
                Console.WriteLine();
                shouldContinue = false;
            }
        } while (shouldContinue);
    }
    private static void ExerciseSevenKindOfLikeExerciseSix()
    {
        //Use a do -while loop to run exercise 1 in a loop.
        //Each time you run the code ask the user whether they would like to continue.
        bool shouldContinue;
        do
        {
            Console.WriteLine("**Exercise 7 Do While Loop Exercise 1**");
            ExericiseOneStringInput();
            Console.WriteLine();
            Console.WriteLine("Would you like to continue (y / n) ?");
            string userInput = Console.ReadLine().ToLower();
            if (userInput == "y")
            {
                shouldContinue = true;
            }
            else
            {
                Console.WriteLine("See Ya!");
                Console.WriteLine();
                shouldContinue = false;
            }

        } while (shouldContinue);
    }
    private static void ExerciseSixDoWhileLoopContinueYorN()
    {
        //EXERCISES: Loops, Expressions, and Control
        //Use a do -while loop to output "Hello, World!" in a loop.
        //Each time you output "Hello, World!" ask the user whether they would like to continue.
        bool shouldContinue;
        do
        {
            Console.WriteLine();
            Console.WriteLine("**Exercise 6 Do While Loop**");
            Console.WriteLine();
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Would you like to continue (y / n) ?");
            string userInput = Console.ReadLine().ToLower();
            if (userInput == "y")
            {
                shouldContinue = true;
            }
            else
            {
                Console.WriteLine("See Ya!");
                Console.WriteLine();
                shouldContinue = false;
            }
        } while (shouldContinue);
    }

    private static void ExerciseFiveMultipyTwoIntegers()
    {
        //Prompt the user to enter two numbers. After the user enters the numbers, multiply them and output the product back to the console.
        Console.WriteLine("**Exercise 5 Multiplication**");
        Console.WriteLine();
        Console.WriteLine("Enter a number: ");
        double userInput = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter another number: ");
        double userInputAgain = double.Parse(Console.ReadLine());
        double theProduct = userInput * userInputAgain;
        Console.WriteLine($"The product is {theProduct}");
        Console.WriteLine();
    }

    private static void ExerciseFourAddTwoIntgers()
    {
        //Prompt the user to enter two numbers. After the user enters the numbers, add them together and output the sum back to the console.
        Console.WriteLine("**Exercise 4 Addition**");
        Console.WriteLine();
        Console.WriteLine("Enter a number: ");
        double userInput = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter another number: ");
        double userInputAgain = double.Parse(Console.ReadLine());
        double theSum = userInput + userInputAgain;
        Console.WriteLine($"The sum is {theSum}");
        Console.WriteLine();
    }
    private static void ExerciseThreeIntegerInput()
    {
        //Prompt the user to enter a number. After the user enters a number, add .5 to the number and output it back to the console.
        Console.WriteLine("**Exercise 3 Add 0.5 to Any Number**");
        Console.WriteLine();
        Console.WriteLine("Please enter a number: ");
        double userInput = double.Parse(Console.ReadLine());
        Console.WriteLine($"You entered {userInput}, plus .5 = {userInput + 0.5}");
        Console.WriteLine();
    }
    private static void ExerciseTwoIntegerInput()
    {
        //Prompt the user to enter a number. After the user enters a number, add 1 to the number and output it back to the console.
        Console.WriteLine("**Exercise 2 Add 1 to Any Number**");
        Console.WriteLine();
        Console.WriteLine("Please enter a number: ");
        double userInput = double.Parse(Console.ReadLine());
        Console.WriteLine($"You entered {userInput}, plus 1 = {userInput + 1}.");
        Console.WriteLine();
    }
    private static void ExericiseOneStringInput()
    {
        //Prompt the user to enter a string. After the user enters a string, output the same string back to the console.
        Console.WriteLine("**Exercise 1 String Users Input**");
        Console.WriteLine();
        Console.WriteLine("Please tell me your name: ");
        string userInput = Console.ReadLine();
        Console.WriteLine($"Nice to meet you {userInput}.");
        Console.WriteLine();
    }
}














//EXERCISE 12

//Description
//Output all the numbers from 9 to 0. Use a for loop to output all the numbers from 9 to 0.

//Example
//>>9 8 7 6 5 4 3 2 1 0
//Would you like to continue (y/n)? << y
//>> 9 8 7 6 5 4 3 2 1 0
//Would you like to continue (y/n)? << y
//>> 9 8 7 6 5 4 3 2 1 0
//Would you like to continue (y/n)? << n
//>> Goodbye!



//EXERCISE 13
//Description
//Prompt the user for a number. Use a for loop to output all the numbers from that number to 0.

//Example
//>>Enter a number: << 5
//>> 5 4 3 2 1 0
//Would you like to continue (y/n)? << y
//>> Enter a number: << 12
// >> 12 11 10 9 8 7 6 5 4 3 2 1 0
//Would you like to continue (y/n)? << n
//>> Goodbye!



//EXERCISE 14

//Description
//Prompt the user for a number. Use a for loop to output the squares of all the numbers from 1 to that number.

//Example
//>>Enter a number: << 2
//>> 1 4
//Would you like to continue (y/n)? << y
//>> Enter a number: << 7
// >> 1 4 9 16 25 36 49
//Would you like to continue (y/n)? << n



//EXERCISE 15

//Description
//Prompt the user for a number. Use a for loop to output the cubes of all the numbers from 1 to that number.

//Example
//>>Enter a number: << 2
//>> 1 8
//Would you like to continue (y/n)? << y
//>> Enter a number: << 7
// >> 1 8 27 64 125 216 343
//Would you like to continue (y/n)? << n
//>> Goodbye!
