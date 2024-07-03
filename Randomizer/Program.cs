using Randomizer.Services;
using System;
using Tynamix.ObjectFiller;

namespace Randomizer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RandomGeneratorServices randomGeneratorServices = new RandomGeneratorServices();

            string isContinue;
            do
            {
                try
                {
                    Console.WriteLine("Which service do you want to use?");

                    Console.WriteLine("1. Random Full name");
                    Console.WriteLine("2. Random Email address");
                    Console.WriteLine("3. Random Integer range");
                    Console.WriteLine("4. Random Lorem ipsum text");
                    Console.Write("Your choice: ");

                    string userChoice = Console.ReadLine();
                    int convertUserChoice = Convert.ToInt32(userChoice);

                    Console.WriteLine("How many random do you want to generate?");
                    Console.Write("Enter the value: ");

                    string userInput = Console.ReadLine();
                    int userInputValue = Convert.ToInt32(userInput);

                    switch (convertUserChoice)
                    {
                        case 1:

                            randomGeneratorServices.GenerateFullName(userInputValue);
                            break;

                        case 2:

                            randomGeneratorServices.GenerateEmailAddress(count: userInputValue);
                            break;

                        case 3:

                            Console.Write("Enter a random starting value: ");
                            string userInputMinValue = Console.ReadLine();
                            int userMinValue = Convert.ToInt32(userInputMinValue);

                            Console.Write("Enter a random ending value: ");
                            string userInputMaxValue = Console.ReadLine();
                            int userMaxValue = Convert.ToInt32(userInputMaxValue);
                            randomGeneratorServices.GenerateIntRange(count: userInputValue, min: userMinValue, max: userMaxValue);
                            break;

                        case 4:

                            Console.Write("Enter the number of words: ");
                            Console.WriteLine("How many words do you need?");
                            string userInputText = Console.ReadLine();
                            int userTextValue = Convert.ToInt32(userInputText);
                            randomGeneratorServices.GenerateLoremIpsum(count: userInputValue, numberOfWords: userTextValue);
                            break;
                    }
                }
                catch (Exception exception)
                {
                    Console.WriteLine($"You entered an invalid value: {exception.Message}\n");
                }

                Console.WriteLine("Do you want to continue? (y / n)");
                isContinue = Console.ReadLine();

            } while (isContinue.ToLower() == "y");

            Console.WriteLine("Thank you!");
        }
    }
}
