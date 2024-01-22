using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__working_with_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // printing numbers
            Console.WriteLine(6);
            // you can also use operators right  in the write line method ie + - * /
            Console.WriteLine(2 + 3);
            //modulo, to get the remainder  of division use %
            Console.WriteLine(5%2);
            //BODMAS still applies, 4+2*3 gets 10, use brackets to change the order
            Console.WriteLine(4+2*3);
            // whatever you do with intergers you get an ingeger back.
            Console.WriteLine(7/2); // will give 3 and not 3.5
            // if you use a decimal and an integer  you always get a double
            Console.WriteLine(5/2.0); //will give 2.5
            // you can also give a number to a variable
            int num = 5;
            // can increment or decrement by 1
            num++;
            Console.WriteLine(num);
            //calling methods, eg the Math method, Abs means absolute
            // you will alwys get a positive number
            Console.WriteLine(Math.Abs(-40));
            // to raise  to powers
            Console.WriteLine(Math.Pow(3,2));
        }
    }
}
