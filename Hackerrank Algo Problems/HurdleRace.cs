using System;
using System.Collections.Generic;

namespace Hackerrank_Algo_Problems
{
    public class HurdleRace
    {
        private static int k = 1;
        private static List<int> height = new List<int> {1,2,3,3,2};
        public static int Execute()
        {
            int largestJumpHeight = 0;
            
            foreach(var num in height)
            {
                if (num - k > largestJumpHeight)
                {
                    largestJumpHeight = num - k;
                }
            }
            
            Console.WriteLine("Hurdle Race!");
            return largestJumpHeight;
        }
    }
}