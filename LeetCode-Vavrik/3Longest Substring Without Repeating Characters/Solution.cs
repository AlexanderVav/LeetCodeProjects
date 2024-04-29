public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        int maxLength = 0;
        for (int start = 0; start < s.Length; start++)
        {
            var seenChars = new HashSet<char>();
            int end;
            for (end = start; end < s.Length; end++)
            {
                if (seenChars.Contains(s[end]))
                {
                    break;
                }
                seenChars.Add(s[end]);
            }
            maxLength = Math.Max(maxLength, end - start);
        }
        return maxLength;
    }
}