using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int FindShortestSubArray(int[] nums)
    {
        Dictionary<int, int> count = new Dictionary<int, int>();
        Dictionary<int, int> firstIndex = new Dictionary<int, int>();
        int maxDegree = 0;
        int minLength = int.MaxValue;

        for (int i = 0; i < nums.Length; i++)
        {
            if (!firstIndex.ContainsKey(nums[i]))
                firstIndex[nums[i]] = i;

            if (!count.ContainsKey(nums[i]))
                count[nums[i]] = 0;

            count[nums[i]]++;

            if (count[nums[i]] == maxDegree)
                minLength = Math.Min(minLength, i - firstIndex[nums[i]] + 1);

            else if (count[nums[i]] > maxDegree)
            {
                maxDegree = count[nums[i]];
                minLength = i - firstIndex[nums[i]] + 1;
            }
        }

        return minLength;
    }
}