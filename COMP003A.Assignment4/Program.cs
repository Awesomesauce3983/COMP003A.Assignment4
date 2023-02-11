/*  Author: Anastasia Clements
 *  Course: COMP-003A
 * Purpose: Assignment 4 (loops!)*/
namespace COMP003A.Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Please the height of the triangle:");
            int limit = Convert.ToInt32(Console.ReadLine());
            string output = "#";
            for (int i = 0; i < limit; i++) {
                Console.WriteLine(output);
                output += "#"; }
            Console.WriteLine($"Thats {limit * (limit + 1) * 0.5} #'s!");
            string[] friends = new string[] { "Rachel", "Joey", "Chandler", "Ross", "Monica", "Phoebe"};
            foreach (var friend in friends) { Console.WriteLine(friend); }
            int counter = 0;
            do {
                Console.WriteLine(counter);
                counter += 5;} while (counter <= 50);
            int counter2 = 1;
            while (counter2 <= 20) {
                if (counter2 % 2 == 0 && counter2 % 5 != 0) { Console.WriteLine("Foo"); }
                else if (counter2 % 5 == 0 && counter2 % 2 != 0) { Console.WriteLine("Bar"); }
                else if (counter2 % 2 == 0 && counter2 % 5 == 0) { Console.WriteLine("FooBar"); }
                else { Console.WriteLine(counter2); }
                counter2 += 1;
            }
        }
    }
}