public class Solution
{
    public int ClimbStairs(int n) 
    {
        if (n <= 0)
        {
            return 0;
        }
        
        if (n == 1)
        {
            return 1;
        }
        
        if (n == 2)
        {
            return 2;
        }
        
        int first = 1;
        int second = 2;
        
        for (int i = 3; i <= n; i++)
        {
            int third = first + second;
            first = second;
            second = third;
        }
        
        return second;
    }
}