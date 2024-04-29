// See https://aka.ms/new-console-template for more information

public static class Program
{
    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        var result = solution.GenerateParenthesis(3);
        Console.WriteLine();
    }
}

public class Solution {
    public IList<string> GenerateParenthesis(int n) {
        var result = new List<string>();
        backtrack(result, "", 0, 0, n);
        return result;
    }

    private void backtrack(List<String> output_arr, String current_string, int open, int close, int max) {
        //wichtig hier ist der Entscheidungsbaum
        if (current_string.Length == max * 2) {
            output_arr.Add(current_string);
            return;
        }
        
        //geht auch hier beide wege weil es rekursiv ist 
        if (open < max)
        {
            current_string += "(";
            backtrack(output_arr, current_string, open+1, close, max);
        }

        //so könnte man auch einen Baum durchsuchen  
        if (close < open)
        {
            current_string += ")";
            backtrack(output_arr, current_string, open, close+1, max);
        }
    }
}