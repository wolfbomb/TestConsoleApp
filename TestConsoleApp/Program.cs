using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //SortString("asoiuyhnafdmnawelk");
            Fibonacci(15);
            Console.ReadLine();
        }

        static void SortString(string input)
        {
            var s = input.ToCharArray().ToList().OrderBy(x => x);

            foreach (var item in s)
            {
                Console.WriteLine(item);
            }
                        
        }

        static void Fibonacci(int length)
        {
            int num1 = 0, num2 = 1, num3 = 0;


            Console.WriteLine(num1);
            for (int i = 0; i < length; i++)
            {

                num1 = num2;
                num2 = num3;
                num3 = num1 + num2;
                Console.WriteLine(num3);


            }
        }

    }
}
