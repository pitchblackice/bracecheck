using System;
using System.Collections.Generic;

namespace First_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            // List of input strings with curly braces
            List<string> inputList = new List<string>();
            inputList.Add("{}");
            inputList.Add("}{");
            inputList.Add("{{}");
            inputList.Add("");
            inputList.Add("{abcxyz}");
            inputList.Add("}}}{{{");

            // Using BraceCheck, verify the input strings contain matching braces. If they do, return
            // true, and if they do not then return false.
            Console.WriteLine("--- Verify the input strings contain matching curly braces ---");
            foreach ( string c in inputList) {
                Console.WriteLine("{0} - {1}", c, BraceCheck(c));
            }
        }

        // BraceCheck validates that the input string contains matches curly braces  
        public static bool BraceCheck(string inputString) {
            int braceCount = 0;
            foreach (char c in inputString) {
                if (c == '{') {
                    braceCount++;
                } else if (c == '}' && braceCount > 0) {
                    braceCount--;
                }
            }
            if (braceCount == 0) 
            {
                return true;
            } else {
                return false;
            }
        }
    }
}
