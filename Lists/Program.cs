using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() { 1,2,3,4};

            //Add
            // no add method in an array.  You can only add to a list once it's declared
            numbers.Add(1);
            //AddRange
            numbers.AddRange(new int[3] { 5, 6, 7});

            foreach (var n in numbers) {
                Console.WriteLine(n);
            }
            
            //various methods
            Console.WriteLine("Index of 1: " + numbers.IndexOf(1));
            Console.WriteLine("Last Index of 1: " + numbers.LastIndexOf(1));
            Console.WriteLine("Count: " + numbers.Count);

            //remove
            //you cannot modify a collection within a foreach loop; use a for loop
            //foreach (var n in numbers) {

            //    if (n == 1) {
            //        numbers.Remove(n);
            //    }
            //}

            //you need to do it this way

            for (var i = 0; i < numbers.Count; i++) {
                numbers.Remove(numbers[i]);
            }
            //after remove

            foreach (var n in numbers) {
                Console.WriteLine(n);
            }

            //and finally, clear

            numbers.Clear();

            Console.WriteLine("After Clear");
            Console.WriteLine("Count: " + numbers.Count);
        }
    }
}
