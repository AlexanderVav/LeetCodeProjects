// See https://aka.ms/new-console-template for more information

public static class Program
{
    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        var result = solution.PlusOne(new[] { 1,2,3 });
    }
}

public class Solution {
    public int[] PlusOne(int[] digits)
    {
        if (digits.Length == 0)
        {
            return digits;
        }
        
        int transfer = 0;
        for (int index = digits.Length-1; index >= 0; index--)
        {
            if (digits[index] == 9)
            {
                digits[index] = 0;
                transfer = 1;
                continue;
            }

            if (transfer == 1)
            {
                digits[index] = digits[index] + transfer;
                transfer = 0;
            }
            else
            {
                digits[index]++;
            }
            break;
        }

        if (transfer == 0) 
            return digits;
        var result = new List<int>(digits);
        result.Insert(0, 1);
        return result.ToArray();

    }
}