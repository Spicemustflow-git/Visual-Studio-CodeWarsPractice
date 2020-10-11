using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            // All code is run from here. I call a specific method or use a class file with methods in it. 
            // Methods are named after the CodeWars exercise and level

            /*~~Start: 8kyu Multiply
            
            //How to call and use a static method. Because the static method belongs to the class and not the object, we cannot
            //create a new object and then call a static method. 
            int answer_static = Problem_8_multiply.Multiply(5, 3);
            Console.WriteLine(answer_static);

            //Here we have created a new object of the Problem_8_multiply class, and called on the non-static method that
            //the object has. 
            Problem_8_multiply answer_obj = new Problem_8_multiply();
            int answer_dynamic = answer_obj.Multiply_2(5, 3);
            Console.WriteLine(answer_dynamic);

            //~~End: 

            /* //~~Start: 7kyu VowelCount
            string s = "Nope!";
            Console.WriteLine(Problem_7_VowelCount.GetVowelCount(s));

            //~~End: 

            /* //~~Start: 8kyo Even or Odd
            int a = 42;
            Console.WriteLine(Problem_8_EvenOdd.EvenOrOdd(a));

            //~~End: */

            /*//~~Start: 7kyu Get the Middle character

            //string s = "testing"; ODD
            string s = "apples";
            Console.WriteLine(Problem_7_GetMiddleCharacter.GetMiddle(s));
            //~~End: */
        }
    }

    class Problem_8_multiply
    {
        public static int Multiply(int a, int b) 
            // This is static, meaning it belongs to the class and cannot be called by an newly createt by an object of the class. 
            // It can only be called "directly", i.e. Class.Method(arg,arg)
        {
            int product = a * b;
            return product;
        }

        public int Multiply_2(int a, int b)
        {
            int product = a*b;
            return product;
        }

    }

    class Problem_7_VowelCount
    {
        public static int GetVowelCount(string s)
        {
            int counter = 0; //Counter of Vowels

            //We convert the string to a List of characters so we can compare char to char
            List<char> ss = new List<char>(); //Create a new list of the type char
            ss.AddRange(s); //We add each character in string s to the end of the list
           
            char[] vowels = {'a', 'e', 'i', 'o', 'u'}; //This is the character array containing all the vowels as characters
            List<char> vowels_array = new List<char>(vowels);

            // code to count the vowels
            foreach (char i in ss)
            {
                if (vowels_array.Contains(i))
                {
                    counter += 1;
                }
            }

            //return counter;

            return s.Count((i => "aeiou".Contains(i))); //This is the simplified version: => = lambda expression. We count the number of occurences
            //of "aeiou" in s. 
        }
    }

    class Problem_8_EvenOdd
    {
        public static string EvenOrOdd(int x)
        {
            string even = "Even";
            string odd = "Odd";
            if (x%2 == 0) //All even numbers are divisible by 2 without any remainders. 
            {
                return even;
            }
            else { return odd; }
        }
    }

    class Problem_7_GetMiddleCharacter
        // Return the single middle char if the length of the string is odd, both middle chars if even
        // "Even" = 4%2 = 0. Length/2 = second middle character, (length/2) -1 = first middle character. 
}
