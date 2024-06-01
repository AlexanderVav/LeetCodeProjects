using System.Text;

public class Solution {
    public string CountAndSay(int n)
    {
        if (n == 1)
            return "1";
        
        string previous = CountAndSay(n - 1);
        return GenerateNextSequence(previous);
    }

    private string GenerateNextSequence(string currentString)
    {
        StringBuilder result = new StringBuilder();
        int count = 1;
        
        for (int index = 1; index < currentString.Length; index++)
        {
            if (currentString[index] == currentString[index - 1])
                count++;
            else
            {
                result.Append(count.ToString());
                result.Append(currentString[index - 1]);
                count = 1;
            }
        }

        // Append the last group
        result.Append(count.ToString());
        result.Append(currentString[currentString.Length - 1]);
        
        return result.ToString();
    }
}