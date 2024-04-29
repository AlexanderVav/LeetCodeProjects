// See https://aka.ms/new-console-template for more information

public static class Program
{
    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        
        /*
        var array = new int[2,2] { {0, 1}, {1, 0} };
        var resulFirst = solution.ShortestPathBinaryMatrix(new int[][] { [0, 1], [1, 0] });
        Console.WriteLine($"wished first: 2 got {resulFirst}");
        var resultSecond = solution.ShortestPathBinaryMatrix(new int[][] { [0,0,0],[1,1,0],[1,1,0]});
        Console.WriteLine($"wished second : 4 got {resultSecond}");
        var resultThrid = solution.ShortestPathBinaryMatrix(new int[][] { [1,0,0],[1,1,0],[1,1,0]});
        Console.WriteLine($"wished third : -1 got {resultThrid}");
        var resultFourth = solution.ShortestPathBinaryMatrix(new int[][] { [0,0,0],[1,0,0],[1,1,0] });
        Console.WriteLine($"wished Fourth : 3 got{resultFourth}");
        
        */
        
        var resultSecond = solution.ShortestPathBinaryMatrix(new int[][] { [0,0,0],[1,1,0],[1,1,0]});
        Console.WriteLine($"wished second : 4 got {resultSecond}");
    }
}