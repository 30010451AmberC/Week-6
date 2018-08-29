using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Exercises___Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1:
            Console.WriteLine("Please enter a letter and I will tell you whether it's a vowel or not: y is a consonant");
            string letter = Console.ReadLine();
            Console.WriteLine("Please press enter to exit");
            vowel(letter);

            //Question 2:
            Console.WriteLine("Please enter you weight in KGs");
            int weight = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your height in CMs ");
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine("Your BMI is " + (weight/(height*height)));

            //Question 3:



       
        }

        public static void vowel(string letter)
        {
            if (letter == "a" || letter == "e" || letter == "i" || letter == "o" || letter == "u" )
            {
                Console.WriteLine("The letter you entered is a VOWEL!");
            } else
            {
                Console.WriteLine("The letter you entered is a consonant.");
            }
        }

       
    }
}
