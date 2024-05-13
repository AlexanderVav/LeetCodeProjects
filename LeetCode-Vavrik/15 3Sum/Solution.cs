public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        IList<IList<int>> result = new List<IList<int>>();
        //here the sort is very important now we can solve the problem with pointers
        Array.Sort(nums);

        for (int i = 0; i < nums.Length - 2; i++) {
            if (i == 0 || (i > 0 && nums[i] != nums[i - 1])) {
                int left = i + 1;
                int right = nums.Length - 1;

                while (left < right) {
                    int sum = nums[i] + nums[left] + nums[right];

                    if (sum == 0) {
                        result.Add(new List<int> { nums[i], nums[left], nums[right] });

                        //here if one pointer is pointing to a duplicate we can jump over it
                        while (left < right && nums[left] == nums[left + 1]) 
                            left++;
                        while (left < right && nums[right] == nums[right - 1]) 
                            right--;

                        //ordinary incrementation of pointers
                        left++;
                        right--;
                    } else if (sum < 0) {
                        left++;
                    } else {
                        right--;
                    }
                }
            }
        }
        return result;
    }
}