using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

partial class Solution
{
    public static string _testCase = "03";
    static void Main(string[] args)
    {
        var (inputFileName, myOutputFileName, expectedOutputFileName) = GetFileNames(_testCase);
        Console.SetIn(new StreamReader(inputFileName));
        HackerRankCode();
        Console.WriteLine(CompareMyOutputWithExpectedOutput(myOutputFileName, expectedOutputFileName));
    }

    // insert hackerrank main code here
    public static void HackerRankCode()
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        Result.countSwaps(a);
    }

    // insert hackerrank class & function below
    class Result
    {
        /*
         * Complete the 'countSwaps' function below.
         *
         * The function accepts INTEGER_ARRAY a as parameter.
         */

        public static void countSwaps(List<int> a)
        {
            var swapCount = 0;
            for (int i = 0; i < a.Count; i++)
            {
                for (int j = 0; j < a.Count - 1; j++)
                {
                    // Swap adjacent elements if they are in decreasing order
                    if (a[j] > a[j + 1])
                    {
                        var temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                        swapCount++;
                    }
                }
            }

            // verify locally that stuff passes testcases
            WriteLinesToFile(new List<string>
            {
                $"Array is sorted in {swapCount} swaps.",
                $"First Element: {a.First()}",
                $"Last Element: {a.Last()}"
            });
        }
    }
}
