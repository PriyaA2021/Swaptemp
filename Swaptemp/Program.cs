using System;

namespace Swaptemp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b,c;
            Console.WriteLine("Enter a,b");
            a = Convert.ToInt32(Console.ReadLine());
            b= Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("Before Swap a=" + a + " b=" +b);
            c = a;
            a = b;
            b= c;

            
            Console.WriteLine("After swap a=" + a + " b=" +b);

            
        }
    }
}
