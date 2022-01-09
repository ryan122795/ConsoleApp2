// See https://aka.ms/new-console-template for more information
using System; // main using command
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
            string characterName = "John";
            int characterAge = 35;
            string phrase = "Giraffe Academy";
            char grade = 'B';
            bool isMale = true;

            Console.WriteLine("Hello\nWorld!");
            Console.WriteLine(characterName);
            Console.WriteLine(characterAge);
            Console.WriteLine(phrase);
            Console.WriteLine(grade);
            Console.WriteLine(isMale);
            Console.WriteLine(phrase.Length);
            Console.WriteLine(phrase.Contains("Academies"));
            Console.WriteLine(-5.432);
            
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);

            //

            int num = Convert.ToInt32("45");
            Console.WriteLine(num);

            Console.Write("Enter a number: ");
            int readNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(readNum);

            // ARRAYS

            int[] luckyNumbers = {4, 8, 15, 16, 23, 42};
            Console.WriteLine(luckyNumbers[1]); // Access the 2nd element of the array

            // METHODS
            string randName = "Mike";
            int randAge = 36;
            SayHi(randName, randAge);

            // RETURN STATEMENT
            int cubed = 5;
            Console.WriteLine(cubed);
            int newNum = cubeNum(cubed);
            Console.WriteLine(newNum);

            */

            // if statements
            
            bool isFemale = false;
            bool isTall = true;

            if (isFemale)
            {
                Console.WriteLine(isFemale);
            } 
            else if (!isFemale && !isTall)
            {
                Console.WriteLine("You are not female and you are tall");
            }
            else
            {
                Console.WriteLine("you are not female");
            }

            // Switch Statements
            Console.WriteLine(GetDay(1));

            // while loop

            int index = 1;
            while (index <= 5)
            {
                Console.WriteLine(index++);
            }

            do
            {
                Console.WriteLine(index);
            }
            while (index <= 5);

            // while commit 2 tes



            //

            Console.ReadLine();
        }

        // METHODS

        static string GetDay(int dayNum)
        {
            string dayName;

            switch (dayNum)
            {
                case 0:
                    dayName = "Sunday";
                    break;
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;
                default:
                    dayName = "none";
                    break;
            }

            return dayName;
        }
        static void SayHi(string name, int age)
        {
            Console.WriteLine("Hello " + name + " you are " + age);
        }

        static int cubeNum(int num)
        {
            int result = num * num * num;
            return result;
        }
    }
}


