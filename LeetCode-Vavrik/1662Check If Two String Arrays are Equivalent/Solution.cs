public class Solution {
    public bool ArrayStringsAreEqual(string[] word1, string[] word2)
    {
        var charsFirst = GetCharArray(word1);

        var charsSecond = GetCharArray(word2);
        
        if (charsFirst.Length != charsSecond.Length)
            return false;

        for (var index = 0; index < charsFirst.Length; index++)
        {
            var first = charsFirst[index];
            var second = charsSecond[index];
            
            if (charsFirst[index] != charsSecond[index])
                return false;
        }

        return true;
    }

    private char[] GetCharArray(string[] word1) => word1.SelectMany(current => current).ToArray();
}