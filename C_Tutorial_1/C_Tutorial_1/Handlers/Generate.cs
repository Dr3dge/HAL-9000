using System;
using System.Collections.Generic;
using System.Web;
using System.Linq;
using System.Text;

namespace HAL_9000
{
    class Generate
    {
        public static void Random()
        {
            Console.WriteLine("What do you want me to generate?");
            string type = Console.ReadLine();

            if (type == "number" || type == "Number")
            {
                Random Rand = new Random();
                long numberOut = Rand.Next(0, 2147483647);

                Console.WriteLine("Your number is: " + numberOut);
            }
            else if (type == "password" || type == "Password")
            {
                Console.WriteLine("How long do you want your password?");
                int numb;
                string numbIn = Console.ReadLine(); 
                try
                {
                    numb = Convert.ToInt32(numbIn);
                }
                catch (Exception)
                {
                    Console.WriteLine("I'm sorry Dave, I'm afraid I can't do that.");
                    Console.WriteLine("You will get a 12 character password");
                    numb = 12;
                }


                var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789/!?<>,.;:'@#$%^&*()_+-={}|[]";
                var random = new Random();
                var randOut = new string(
                Enumerable.Repeat(chars, numb).Select(s => s[random.Next(s.Length)]).ToArray());

                Console.WriteLine("Here you are: " + randOut);
            }
            else if (type == "word" || type == "Word")
            {
                Console.WriteLine("How long do you want your word?");
                int numb;
                string numbIn = Console.ReadLine();
                try
                {
                    numb = Convert.ToInt32(numbIn);
                }
                catch (Exception)
                {
                    Console.WriteLine("I'm sorry Dave, I'm afraid I can't do that.");
                    Console.WriteLine("You will get a 6 character word");
                    numb = 6;
                }

                var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
                var random = new Random();
                var randOut = new string(
                Enumerable.Repeat(chars, numb).Select(s => s[random.Next(s.Length)]).ToArray());

                Console.WriteLine("Here you are: " + randOut);
            }
            else if (type == "matrix" || type == "Matrix")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.BackgroundColor = ConsoleColor.Black;

                var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
                var matrix = new Random();
                var matrixOut = new string(
                Enumerable.Repeat(chars, 800000).Select(s => s[matrix.Next(s.Length)]).ToArray());

                Console.WriteLine(matrixOut);
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.White;
            }
        }
    }
}
