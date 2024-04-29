public class Solution {
    public bool CanJump(int[] nums)
    {
        var currentIndex = 0;
        var currentMax = nums[0];
        for (var index = 0; index <= currentMax; index++)
        {
            var tempJump = nums[index];
            for (int indexJumpedTo = index; indexJumpedTo <= tempJump; indexJumpedTo++)
            {
                if (index == indexJumpedTo)
                    continue;
                var newMax = nums[indexJumpedTo] + indexJumpedTo;
                if (newMax >= currentMax)
                {
                    currentMax = newMax;
                    tempJump = currentMax;
                }

                if (nums.Length-1 <= currentMax)
                    return true;
            }

            if (currentMax <= tempJump)
            {
                currentMax = tempJump;
            }

            if (nums.Length-1 <= currentMax)
                return true;
        }

        return false;
    }
}