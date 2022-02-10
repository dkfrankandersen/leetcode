using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_solutions
{
    class Solution
    {
        public int[] GetConcatenation(int[] nums)
        {
            int[] nums_concat = new int[2*nums.Length];
            nums.CopyTo(nums_concat, 0);
            nums.CopyTo((int[])nums_concat, nums.Length);
            return nums_concat;
        }
    }

    public static class P_1929_Concatenation_of_Array {

        public static void run() {
            Solution solution = new Solution();
            int[] nums = { 1, 2, 1 };
            int[] result = solution.GetConcatenation(nums);

            Console.WriteLine("Expectations:");
            Console.WriteLine("Input: nums = [1,2,1]");
            Console.WriteLine("Output: [1,2,1,1,2,1]");

            Console.WriteLine("Results:");
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
