public class Solution
{
    private const char RoundBracketOpen = '(';
    private const char RoundBracketClosed = ')';
    private const char SquareBracketOpen = '[';
    private const char SquareBracketClosed = ']';
    private const char CurvedBracketOpen = '{';
    private const char CurvedBracketClosed = '}';
    
    public bool IsValid(string s)
    {
        if (s.Length == 0 || s.Length % 2 != 0)
            return false;
        Stack<char> lookup = new Stack<char>(s.Length);
        foreach (var currentChar in s)
        {
            if ((currentChar.Equals(RoundBracketOpen) || currentChar.Equals(SquareBracketOpen) || currentChar.Equals(CurvedBracketOpen)))
                lookup.Push(currentChar);
            
            if ((currentChar.Equals(RoundBracketClosed) || currentChar.Equals(SquareBracketClosed) || currentChar.Equals(CurvedBracketClosed)))
                if (lookup.Count >= 1 && InvertCharBracket(lookup.Peek()).Equals(currentChar))
                    lookup.Pop();
                else
                    return false;
        }

        if (lookup.Count == 0)
        {
            return true;
        }

        return false;
    }

    private char InvertCharBracket(char current)
    {
        switch (current)
        {
            case RoundBracketOpen: return RoundBracketClosed;
            case SquareBracketOpen: return SquareBracketClosed;
            case CurvedBracketOpen: return CurvedBracketClosed;
        }

        return '!';
    }
}