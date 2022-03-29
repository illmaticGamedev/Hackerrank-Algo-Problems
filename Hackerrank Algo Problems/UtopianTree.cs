using System;

namespace Hackerrank_Algo_Problems
{
    public class UtopianTree
    {
        private static int n = 5;

        public static int Execute()
        {
            int currentHeight = 1;
            
            for (int i = 0; i < n; i++)
            {
                if (i == 0 || i % 2 == 0)
                {
                    currentHeight = currentHeight * 2;
                }
                else
                {
                    currentHeight = currentHeight + 1;
                }
            }
            
            Console.WriteLine("Utopian Tree");
            return currentHeight;
        }
    }
}