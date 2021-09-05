using System;
using System.Collections.Generic;
using System.IO;
partial class Solution
{
    private static bool CompareMyOutputWithExpectedOutput(string myOutputFileName, string expectedOutputFileName)
    {
        try
        {
            var myOutputFile = File.ReadAllLines(myOutputFileName);
            var expectedOutputFile = File.ReadAllLines(expectedOutputFileName);
            for (var i = 0; i < myOutputFile.Length; i++)
            {
                if (!expectedOutputFile[i].Equals(myOutputFile[i]))
                {
                    return false;
                }
            }

            return true;
        }
        catch
        {
            return false;
        }
    }

    static (string inputFileName, string myOutputFileName, string expectedOutputFileName) GetFileNames(string testNumber)
    {
        return (inputFileName: Path.Combine(GetSolutionPath, GetProblemName, $@"input\input{testNumber}.txt"),
                myOutputFileName: GetOutputFileName(testNumber),
                expectedOutputFileName: Path.Combine(GetSolutionPath, GetProblemName, $@"output\output{testNumber}.txt"));
    }

    static string GetOutputFileName(string testNumber)
    {
        return Path.Combine(GetSolutionPath, GetProblemName, $@"output\myoutput{testNumber}.txt");
    }

    static string GetSolutionPath => Environment.GetEnvironmentVariable("BASE_PATH");
    static string GetProblemName => Environment.GetEnvironmentVariable("PROBLEM");
    static void WriteLinesToFile(List<string> input)
    {
        var myOutputFileName = GetOutputFileName(_testCase);
        using (var textWriter = new StreamWriter(myOutputFileName))
        {
            foreach (var line in input)
            {
                textWriter.WriteLine(line);
            }
        }
    }
}
