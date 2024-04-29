// See https://aka.ms/new-console-template for more information

public static class Progam
{
    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        var firstResult = solution.FindShortestSubArray(new int[] { 1,2,2,1,2,1,1,1,1,2,2,2 });
        //var secondResult = solution.FindShortestSubArray(new int[] { 1,2,2,3,1,4,2 });
        //var thirdResult = solution.FindShortestSubArray(new int[] { 8,8,7,7,7 });
        //var fourthResult = solution.FindShortestSubArray(new int[] { 1,2,2,3,1,4,2 });
        Console.WriteLine($"1. Result : {firstResult}");
        //Console.WriteLine($"3. Result : {fourthResult}");
        
        /*Console.WriteLine($"2. Result : {secondResult}");
        Console.WriteLine($"3. Result : {thirdResult}");
        */
    }
}