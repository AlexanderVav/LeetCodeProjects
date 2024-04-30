public class Solution {
    public string LongestPalindrome(string s) {
        if(s.Length == 1)
            return s;
        int left=0, right=1;
        string maxStr = "";
        while(left < s.Length - 1){
            string str = s.Substring(left, right - left);
            if(CheckPalindromic(str))
            {
                if(str.Length > maxStr.Length)
                    maxStr = str;
            }
            if(right < s.Length)
                right++;
            else{
                left++;
                right = left + 1;
            }
        }
        return maxStr;
    }

    private bool CheckPalindromic(string temp)
    {
        for (int indexChar = 0; indexChar < temp.Length; indexChar++)
        {
            if (temp[indexChar] != temp[temp.Length-1-indexChar])
            {
                return false;
            }
        }

        return true;
    }
    
}