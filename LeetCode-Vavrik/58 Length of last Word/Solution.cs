public class Solution {
    public int LengthOfLastWord(string s)
    {
        var count = 0;
        for (int index = s.Length-1; index >= 0; index--)
        {
            var current = s[index];
            if (current.CompareTo(' ') == 0 && count == 0)
                continue;
            if (current.CompareTo(' ') == 0 && count != 0)
                return count;
            count++;
        }

        return 0;
    }
}