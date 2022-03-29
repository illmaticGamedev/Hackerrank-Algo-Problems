using System;

namespace Hackerrank_Algo_Problems
{
    public class ElectronicShop
    {
        private static int[] keyboards = new[] {40, 50, 60};
        private static int[] drives = new[] {5, 8, 12};
        private static int b = 60;
       public static int Execute() {
            /*
             * Write your code here.
             */
            int lastLargestCost = 0;
         
            for(int i = 0; i < keyboards.Length; i++)
            {
                for(int j = 0; j < drives.Length; j++)
                {
                    int currentComboCost = keyboards[i] + drives[j];
                
                    if(currentComboCost <= b && (currentComboCost > lastLargestCost))
                    {
                        lastLargestCost = currentComboCost;
                    }
                }
            }
         
            Console.WriteLine("ElectronicShop");
            if(lastLargestCost != 0)
            {
                return lastLargestCost;
            } else {
                return -1;
            }
       }
    }
}