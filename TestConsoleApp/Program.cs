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
            SortString("asoiuyhnafdmnawelk");
            Console.ReadLine();
        }

        static void SortString(string input)
        {
            var s = input.ToCharArray().ToList().OrderBy(x => x);

            foreach (var item in s)
            {
                Console.Write(item);
            }
                        
        }

    }
}
