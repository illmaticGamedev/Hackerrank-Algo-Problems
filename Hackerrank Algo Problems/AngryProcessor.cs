using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace Hackerrank_Algo_Problems
{
    public class AngryProcessor
    {
        private static int k = 6;
        private static List<int> a = new List<int>(){-58, -29, -35, -18, 43, -28, -76, 43, -13, 6};
        
        public static string Execute()
        {
            int numberOfLateStudents = 0;

            foreach (var num in a)
            {
                if (num <= 0) numberOfLateStudents += 1;
            }
            
            Console.WriteLine("Angry Processor");
            
            if (numberOfLateStudents < k)
            {
                return "YES";
            }
            else
            {
                return "NO";
            }
        }
    }
}