public class Solution {
    public string LongestCommonPrefix(string[] strs)
    {
        var listOfData = new List<string>(strs);
        listOfData.Sort();
        var result = new HashSet<char>(listOfData.First().ToCharArray());
        
        for (int index = 1; index < strs.Length; index++)
        {
            var temp = new HashSet<char>();
            var currentStrArray = listOfData[index];
            foreach (var currentResultChar in currentStrArray)
            {
                if (result.Contains(currentResultChar))
                    temp.Add(currentResultChar);
                else
                    break;
            }
            if (temp.Count == 0)
                return "";
            result = temp;
        }
        var resultString = "";
        foreach (var current in result)
        {
            resultString += current;
        }

        return resultString;
    }
}