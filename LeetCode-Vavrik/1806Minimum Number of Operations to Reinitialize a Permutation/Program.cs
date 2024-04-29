// See https://aka.ms/new-console-template for more information

public static class Program
{
    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        //Console.WriteLine($"Result :{solution.ReinitializePermutation(2)}");
        Console.WriteLine($"Result :{solution.ReinitializePermutation(4)}");
        //Console.WriteLine($"Result :{solution.ReinitializePermutation(6)}");
        Console.WriteLine($"Result :{solution.ReinitializePermutation(10)}");
    }
}