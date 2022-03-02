using System;

namespace Pac
{
    public class CLI
    {
        public static void Main(string[] args)
        {
            var rand = new Random();
            //string str;
            Console.Write("How many phrases would you like to add... ");
            int repeat = Convert.ToInt32(Console.ReadLine());
            Console.Write("How many characters do you need... ");
            int characters = Convert.ToInt32(Console.ReadLine());
            /*Console.Write("How many phrases would you like to add... ");
            int repeat = Convert.ToInt32(Console.ReadLine());
            Console.Write("How many phrases would you like to add... ");
            int repeat = Convert.ToInt32(Console.ReadLine());*/

            string[] phrases = new string[repeat];

            for (int i = 0; i < repeat; i++)
            {
                Console.Write("Enter a phrase: "); 
                phrases[i] = Console.ReadLine();
            }

            /*
            do
            {

                Console.Write("Type a phrase you would like your password to contain. Leave blank to generate password: ");
                str = Console.ReadLine();

                if (str != "")
                {
                    
                }

            } while (str != "");*/

            //Console.WriteLine(randomNumber(rand, 5, 15));
            string password = "";

            while (password.Length < characters)
            {
                password += phrases[randomNumber(rand, 0, phrases.Length)];
            }


            Console.WriteLine($"Your password is {password}");

            Console.Write("Press the enter key to exit...");
            Console.ReadLine();
        }

        public static int randomNumber(Random random, int min, int max)
        {
            return (int)(random.NextDouble() * (max - min)) + min;
        }
    }
}