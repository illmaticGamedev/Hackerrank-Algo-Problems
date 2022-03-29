using System;
using System.Collections.Generic;

namespace Hackerrank_Algo_Problems
{
    public class DesignPDFViewerHighlight
    {
        private static List<int> h = new List<int>() {1, 3, 1, 3 ,1, 4, 1 ,3 ,2, 5, 5, 5, 5 ,5, 5, 5, 5 ,5 ,5 ,5 ,5 ,5, 5, 5, 5, 5 };
        private static string word = "torn";
        
        public static int Execute()
        {
            int tallestLetter = 0;
            string alphabet = "abcdefghijklmnopqrstuvwxyz";

            for (int j = 0; j < word.Length; j++)
            {
                for (int k = 0; k < alphabet.Length; k++)
                {
                    if (alphabet[k] == word[j] && tallestLetter < h[k])
                    {
                        tallestLetter = h[k];
                    }
                }
            }
            
            Console.WriteLine("Design PDF Viewer Highlight");
            return tallestLetter * word.Length;
        }
    }
}