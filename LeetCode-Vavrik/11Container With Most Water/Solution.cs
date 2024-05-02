namespace _11Container_With_Most_Water;

public class Solution {
    public int MaxArea(int[] height)
    {
        var list = new List<int>(height);
        int left = 0, right = height.Length-1, result = 0;
        while (left < height.Length  && right > left)
        {
            var temp = CalculateArea(left, right, list);
            if (result < temp) 
                result = temp;

            if (list[left] < list[right])
                left++;
            else
                right--;
        }

        return result;
    }

    private int CalculateArea(int left, int right, List<int> list)
    {
        int temp;
        if (list[left] < list[right])
        {
            temp = list[left];
            return temp * (right - left);
        }
        temp = list[right];
        return temp * (right - left);
    }
}