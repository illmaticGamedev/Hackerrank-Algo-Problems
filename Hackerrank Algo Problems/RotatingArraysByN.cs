using System;

namespace Hackerrank_Algo_Problems
{
    public static class RotatingArraysByN
    {
        private static int[] nums = new[] {1,2,3,4,5,6,7};
        private static int k = 3;
        public static void Execute()
        {
            int[] newNums = new int[nums.Length];
            
            for (int i = 0; i < nums.Length; i++)
            {
                if (i >= nums.Length - k)
                {
                    newNums[i - Math.Abs(k-nums.Length)] = nums[i];
                }
                else
                {
                    newNums[i+k] = nums[i];
                }
            }

            Array.Copy(newNums,nums,newNums.Length);
            //Debugging Solution
            Console.WriteLine("Rotating Arrays By N");
            for (int i = 0; i < nums.Length; i++)
            {
               Console.WriteLine(i + " : " + nums[i]);
            }
        }
    }
}