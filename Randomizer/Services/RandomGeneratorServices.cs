using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tynamix.ObjectFiller;

namespace Randomizer.Services
{
    internal class RandomGeneratorServices
    {
        public void GenerateFullName(int count)
        {
            RealNames realNameGenerator = new RealNames();

            Console.WriteLine("There are some fullnames:\n");

            for (int i = 0; i < count; i++)
            {
                string fullNameRandom = realNameGenerator.GetValue();
                Console.WriteLine(fullNameRandom);
            }
        }

        public void GenerateEmailAddress(int count)
        {
            EmailAddresses emailGenerator = new EmailAddresses();

            Console.WriteLine("There are some email adresses:\n");

            for (int i = 0; i < count; i++)
            {
                string emailRandom = emailGenerator.GetValue();
                Console.WriteLine(emailRandom);
            }
        }

        public void GenerateIntRange(int count, int min, int max)
        {
            IntRange intGenerator = new IntRange(min: min, max: max);

            Console.WriteLine("There are some random numbers:\n");

            for (int i = 0; i < count; i++)
            {
                int intRandom = intGenerator.GetValue();
                Console.WriteLine(intRandom);
            }
        }

        public void GenerateLoremIpsum(int count, int numberOfWords)
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
