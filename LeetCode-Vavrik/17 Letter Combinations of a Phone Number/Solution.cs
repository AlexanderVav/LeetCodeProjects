public class Solution
{

    private Dictionary<int, string> lookup = new Dictionary<int, string>()
    {
        { 2, "abc" }, { 3, "def" }, { 4, "ghi" }, { 5, "jkl" }, { 6, "mno" }, { 7, "pqrs" }, { 8, "tuv" }, { 9, "wxyz" }
    };

    private IList<string> result = new List<string>();
    public IList<string> LetterCombinations(string digits)
    {
        if(digits.Length == 0){
            return result;
        }
        
        BackBag("", digits);
        return result;
    }

    private void BackBag(string current, string restOfString)
    {
        if (restOfString.Length == 0)
        {
            result.Add(current);
            return;
        }

        foreach (var currentChar in lookup[int.Parse(restOfString[0].ToString())])
        {
            BackBag(current + currentChar.ToString(), restOfString.Substring(1));
        }
    }
}