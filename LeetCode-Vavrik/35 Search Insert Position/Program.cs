// See https://aka.ms/new-console-template for more information

public static class Program
{
    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        var result = solution.SearchInsert(new[] { 1, 3, 5, 6 }, 2);
    }
}

public class Solution {
    public int SearchInsert(int[] nums, int target)
    {
        int beforeIndex = 0;
        
        for (int index = 0; index < nums.Length; index++)
        {
            if (nums[index] < target) 
                beforeIndex = index;
            
            if (nums[index] == target)
            {
                return index;
            }
        }

        if (beforeIndex == 0 && nums[0] > target)
        {
            return 0;
        }
        return beforeIndex+1;
    }
}
