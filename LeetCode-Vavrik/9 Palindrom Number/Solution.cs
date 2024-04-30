public class Solution {
    public bool IsPalindrome(int x)
    {
        var temp = x.ToString();
        for (int index = 0; index < temp.Length; index++)
        {
            if (temp[0 + index] != temp[temp.Length-1- index])
            {
                return false;
            }
        }

        return true;
    }
}