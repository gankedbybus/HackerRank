Scaffold to help users debug their HackerRank solutions locally

Setup 
1. Add/edit environment variables 
    `BASE_PATH` - where we store our HackerRank TestCases, I've included one in the solution. You will have to change this to match your 
    `PROBLEM` - name of the TestCase you're currently trying to debug/solve
2. Find a HackerRank solution you want to solve and download the sample testcases to the location you configured in the previous step
3. Copy and paste the whole code block in main to the function `HackerRankCode()` in `Program.cs`
4. Copy and paste the class where your solution would normally be written, in the example I've used it's `Result` for the `bubble sort` problem
5. If the solution requires any output to be printed out in the console, you can pass the strings into the `WriteLinesToFile` function to verify it matches locally

   
  
