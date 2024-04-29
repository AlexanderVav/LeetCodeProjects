public class Solution {
    public int MinElements(int[] nums, int limit, int goal) {
        var abs = Math.Abs(GetSum(nums) - goal);
        var rs = abs / limit;
        if (abs % limit > 0) rs++;
        return (int)rs;
    }
    private long GetSum(int[] nums)
    {
        var rs = 0L;
        for (int i = 0; i < nums.Length; i++)
        {
            rs += nums[i];
        }
        return rs;
    }
}