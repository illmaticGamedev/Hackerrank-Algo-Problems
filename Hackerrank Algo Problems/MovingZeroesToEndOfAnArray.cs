using System;
namespace Hackerrank_Algo_Problems
{
    internal  class MovingZeroesToEndOfAnArray
    {
        private static int[] arry = new[] {0,1,0,3,12};
        
        public static void Execute()
        {
            for (int i = 0; i < arry.Length; i++)
            {
                if (arry[i] == 0)
                {
                    for (int j = i + 1; j < arry.Length; j++)
                    {
                        if (arry[j] != 0)
                        {
                            arry[i] = arry[j];
                            arry[j] = 0;
                            break;
                        }
                    }
                }
            }


            for (int i = 0; i < arry.Length; i++)
            {
                Console.WriteLine("Element "+ i + " : " + arry[i]);
            }
            
        }
    }
}