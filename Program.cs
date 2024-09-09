using System.Numerics;
using System.Security.Principal;
using System.Xml.Schema;

namespace topic_3___user_input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age, year, n1, n2, n3, total;
            

            Console.WriteLine("Hello! What is your name?");
            name = Console.ReadLine();
            Console.WriteLine($"Thats a nice name {name}");
            Console.WriteLine("How old are you?");
            age = Convert.ToInt32( Console.ReadLine() );
            

            Console.WriteLine($"Oh, so you're {age} interesting...");
            Console.WriteLine("What year is it again?");
            year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"So you're name is {name} and you are {age} years old and its currently {year}");
            Console.WriteLine();
            Console.WriteLine("Give me 3 numbers (one at a time) and I will add them for you");
            
            n1 = Convert.ToInt32( Console.ReadLine() );
            Console.WriteLine($"Okay {n1} plus?");
            n2 = Convert.ToInt32( Console.ReadLine() );
            Console.WriteLine($"This is too easy so far, give me a HUGE number");
            n3 = Convert.ToInt32( Console.ReadLine() );
            total = n1 + n2 + n3;
            Console.WriteLine("Okay, your total is"  + total);
            double d1, d2, d3;
            Console.WriteLine();
            Console.WriteLine("Im going to calculate the average distances in the numbers you tell me in KM");
            Console.WriteLine("Lets start! Number one?");
            d1 = Convert.ToDouble( Console.ReadLine() );
            Console.WriteLine("Number two?");
            d2 = Convert.ToDouble( Console.ReadLine() );
            Console.WriteLine("number 3?");
            d3 = Convert.ToDouble( Console.ReadLine() );
            total = (int)((d1 + d2 + d3) / 3);
            Console.WriteLine($"So your average distance is {total} per hour");
            double side1, side2;
            Console.WriteLine();
            Console.WriteLine("I am going to give you the hypoteneuse after telling me two legs of a triangle");
            Console.WriteLine("Alright what is the first number");
            side1 = Convert.ToDouble( Console.ReadLine() );
            Console.WriteLine("Number two?");
            side2 = Convert.ToDouble( Console.ReadLine() );
            total = (int)Math.Sqrt(side1 * side1 + side2 * side2);
            Console.WriteLine($"The hypotenuse would be {total}");



        }
    }
}
