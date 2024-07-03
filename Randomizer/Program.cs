using System;
using Tynamix.ObjectFiller;

namespace Randomizer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string isContinue;
            do
            {
                try
                {
                    Console.WriteLine("Which service do you want to use?");

                    Console.WriteLine("1. Full name generator");
                    Console.WriteLine("2. Email address generator");
                    Console.WriteLine("3. Integer range generator");
                    Console.WriteLine("4. Lorem ipsum text generator");
                    Console.Write("Your choice: ");

                    string userChoice = Console.ReadLine();
                    int convertUserChoice = Convert.ToInt32(userChoice);

                    Console.WriteLine("How many random do you want it to generate?");
                    Console.Write("Enter the value: ");

                    string userInput = Console.ReadLine();
                    int userInputValue = Convert.ToInt32(userInput);

                    switch (convertUserChoice)
                    {
                        case 1:

                            GenerateFullName(count: userInputValue);
                            break;

                        case 2:

                            GenerateEmailAddress(count: userInputValue);
                            break;

                        case 3:

                            Console.Write("Enter a random starting value: ");
                            string userInputMinValue = Console.ReadLine();
                            int userMinValue = Convert.ToInt32(userInputMinValue);

                            Console.Write("Enter a random ending value: ");
                            string userInputMaxValue = Console.ReadLine();
                            int userMaxValue = Convert.ToInt32(userInputMaxValue);
                            GenerateIntRange(count: userInputValue, min: userMinValue, max: userMaxValue);
                            break;

                        case 4:

                            Console.Write("Enter the number of words: ");
                            Console.WriteLine("How many words do you need?");
                            string userInputText = Console.ReadLine();
                            int userTextValue = Convert.ToInt32(userInputText);
                            GenerateLoremIpsum(count: userInputValue, numberOfWords: userTextValue);
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

        static void GenerateFullName(int count)
        {
            RealNames realNameGenerator = new RealNames();

            Console.WriteLine("There are some fullnames:\n");

            for (int i = 0; i < count; i++)
            {
                string fullNameRandom = realNameGenerator.GetValue();
                Console.WriteLine(fullNameRandom);
            }
        }

        static void GenerateEmailAddress(int count)
        {
            EmailAddresses emailGenerator = new EmailAddresses();

            Console.WriteLine("There are some email adresses:\n");

            for (int i = 0; i < count; i++)
            {
                string emailRandom = emailGenerator.GetValue();
                Console.WriteLine(emailRandom);
            }
        }

        static void GenerateIntRange(int count, int min, int max)
        {
            IntRange intGenerator = new IntRange(min: min, max: max);

            Console.WriteLine("There are some random numbers:\n");

            for (int i = 0; i < count; i++)
            {
                int intRandom = intGenerator.GetValue();
                Console.WriteLine(intRandom);
            }
        }

        static void GenerateLoremIpsum(int count, int numberOfWords)
        {
            Lipsum lipsumGenerator = new Lipsum(LipsumFlavor.ChildHarold, minWords: numberOfWords);

            Console.WriteLine("There are some random texts:\n");

            for (int i = 0; i < count; i++)
            {
                string lipsumRandom = lipsumGenerator.GetValue();
                Console.WriteLine(lipsumRandom);
            }
        }
    }
}
