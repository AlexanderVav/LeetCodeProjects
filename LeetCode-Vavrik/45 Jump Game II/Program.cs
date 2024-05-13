// See https://aka.ms/new-console-template for more information

public static class Proram
{
    public static void Main(string[] args)
    {
        var solution = new Solution();
        var result = solution.Jump(new[] { 2, 3, 1, 1, 4 });
        Console.WriteLine();
    }
}

public class Solution {
    public int Jump(int[] nums)
    {
        if (nums.Length == 0 || nums.Length == 1)
            return 0;

        int jump = nums[0], count = 1;
        for (int index = 1; index < nums.Length; index++)
        {
            if (jump >= nums.Length)
                return count;
            jump = GetBiggestWithJump(index, jump, nums) + (jump)-1;
            count++;
        }

        return count;
    }

    private int GetBiggestWithJump(int index, int jump, int[] nums)
    {
        int max = int.MinValue;
        for (int i = index; i < nums.Length; i++)
        {
            if (nums[i] > max)
                max = nums[i];
        }
        return max;
    }
}