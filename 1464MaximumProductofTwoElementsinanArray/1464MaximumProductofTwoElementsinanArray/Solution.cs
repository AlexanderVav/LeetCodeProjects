public class Solution {
    public int MaxProduct(int[] nums)
    {
        int result = 0;
        var listNumb = new List<int>(nums);
        var copy = new List<int>(listNumb.Count);
        listNumb.ForEach(i => copy.Add(i));
        var firstMax = FindMaxAndDelete(listNumb);
        var secondMax = FindMaxAndDelete(listNumb);
        result = (firstMax-1) * (secondMax-1);
        return result;
    }

    private int FindMaxAndDelete(List<int> listNumb)
    {
        var max = int.MinValue;
        var index = 0;
        for (var i = 0; i < listNumb.Count; i++)
        {
            var current = listNumb[i];
            if (max >= current) 
                continue;
            max = current;
            index = i;
        }
        listNumb.RemoveAt(index);
        return max;
    }
}