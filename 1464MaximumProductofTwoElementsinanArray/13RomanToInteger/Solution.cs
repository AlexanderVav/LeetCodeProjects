public class Solution
{

    private Dictionary<string, int> lookupRoman = new Dictionary<string, int>()
    {
        { "I", 1 },
        { "V", 5 },
        { "X", 10 },
        { "L", 50 },
        { "C", 100 },
        { "D", 500 },
        { "M", 1000 }
    };

    public int RomanToInt(string s)
    {
        int resultMid = 0;
        int result = 0;
        s = s.Trim();
        for (var index = 0; index < s.Length; index++)
        {
            var currentLetter = s[index];
            if (index+1 < s.Length) 
                resultMid += GetCurrentRoman(currentLetter);
            
            if (index+1 < s.Length && GetCurrentRoman(currentLetter) < GetCurrentRoman(s[index+1]) )
            {
                if (resultMid == 0) 
                    resultMid = GetCurrentRoman(currentLetter);
                result += GetCurrentRoman(s[index + 1]) - resultMid;
                resultMid = 0;
                index++;
                continue;
            }

            if (resultMid == 0) resultMid = GetCurrentRoman(currentLetter);
            result += resultMid;
            resultMid = 0;
        }

        return result == 0 ? resultMid : result;
    }

    private int GetCurrentRoman(char currentLetter)
    {
        return lookupRoman[currentLetter.ToString()];
    }
}