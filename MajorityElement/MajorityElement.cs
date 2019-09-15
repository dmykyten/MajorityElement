using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MajorityElement
{
    public class MajorityElement
    {
        public int[] StringToIntArray(string input)
        {
            
            int[] arr = new int[input.Length];
            var i = 0;
            foreach (var value in input)
            {
                arr[i] = int.Parse(value.ToString());
                i++;
            }
            return arr;
        }
        public int FindBiggestNumber(int[] nums)
        {
            int count = 0;
            for (int i = 0; i != 10; i++)
            {
                foreach (var value in nums)
                {
                    if (value == i)
                        count++;
                    if (count > nums.Length / 2)
                        return i;
                    
                }
                count = 0;
            }
            return -1;
        }
    }
}
