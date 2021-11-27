using System;

namespace prog
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = 5;
            var y = 6;
            var z = 7;
            Console.WriteLine(x*x+3*x-4);
            Console.WriteLine((x+y)*x); 
            Console.WriteLine((x+3*y)/(2*x-y)); 
            Console.WriteLine(1/(x*x+x+3)); 
            Console.WriteLine((x+y)/7); 
            Console.WriteLine(2*x*y*y*y); 
            Console.WriteLine((3*y)/(5-z)); 
            Console.WriteLine(x*Math.Sqrt(x)); 
            Console.WriteLine((x+32)/(y-32)-(x-2*y)); 
            Console.WriteLine((3*x*y*z + Math.Pow(x,9))/(7*x*y-5*Math.Sqrt(y+z)));
        }
    }
}