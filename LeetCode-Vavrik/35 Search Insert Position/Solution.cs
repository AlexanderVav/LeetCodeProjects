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