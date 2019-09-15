using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MajorityElement   //https://leetcode.com/problems/majority-element/
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var solution = new MajorityElement();
            var arr = solution.StringToIntArray(input);
            var number = solution.FindBiggestNumber(arr);
            Console.WriteLine();
            Console.Write(number);
            Console.ReadKey();
        }
    }
}
