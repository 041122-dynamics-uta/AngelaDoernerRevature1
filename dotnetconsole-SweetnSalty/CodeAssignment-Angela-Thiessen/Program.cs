using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //User input for the next three sections
            Console.WriteLine("Hello, user! Please give me a bottom range value");
            int bottom = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Perfect! Now give me a top range value.");
            int top = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("All set. How many numbers would you like to list today?");
            int quantity = Convert.ToInt32(Console.ReadLine());
            
            //Creating the array with the input from the user
             int range = top - bottom;//finding the range Alec and others helped with this
            IEnumerable<int> all = Enumerable.Range(top, range);//enumerable allows you to use a range method
            int check = 0;//keep count of how many

            //Used to get the total number of instances
            int sw = 0; 
            int st = 0;
            int swst = 0;

            foreach(int s in all)
            {
                if(check == quantity)
                {
                    Console.WriteLine();
                    check = 0;
                }
                if (s % 3 == 0 && s % 5 == 0)//if divisible by 3 and 5
                {
                    Console.WriteLine("Sweet'nSalty");
                    swst++;
                } 
                else if ( s % 3 == 0) //divisible by 3
                {
                    Console.WriteLine("Sweet");
                    sw++;
                }
                else if (s % 5 == 0)//divisble by 5
                {
                    Console.WriteLine("Salty");
                st++;
                }            
                else
                {
                Console.WriteLine($"{s}");//just print number
                }
                check++;                 
            }
            //results
            Console.WriteLine();
            Console.WriteLine($"The Number of Sweets is {sw}");
            Console.WriteLine($"The Number of Salty's is {st}");
            Console.WriteLine($"The Number of Sweet&Salty is {swst}");
            Console.WriteLine();

        }
    }
}