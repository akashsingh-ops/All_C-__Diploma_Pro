//Akash Singh
//RollNo=1805086_3rd_Year
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Random r = new Random();                   // Random class Object
            int winnum = r.Next(0, 100);               //Random number is between 0 and 100
            bool win = false;
            do                                         //DO while Loop for check the condtion after once its has been run 
            {
                Console.Write("Guess the number in betwwen 0 and 100    ");
                string s = Console.ReadLine();
                int i = int.Parse(s);
                if (i > winnum)
                {
                    Console.WriteLine("To hign!!! Guess lower......");

                }
                else if (i < winnum)
                {
                    Console.WriteLine("Go low!!! Guess higher......");

                }
                else if (i == winnum)
                {
                    Console.WriteLine("You Win.......(*-*)");
                    win = true;
                }

                Console.WriteLine();
            }
            while (win == false);                              //condition of while 
            Console.WriteLine("Thank you for playing the game...-_-");
            Console.WriteLine("press any key to finish the game!!!");
            Console.ReadKey(true);
        }
    }
}///End of the code.....
