public class Solution {
    public int[][] GenerateMatrix(int n)
    {
        var result = new int[n][];
        for (int i = 0; i < n; i++)
        {
            result[i] = new int[n];
        }
        int left = 0, right = n-1, top = 0, bottom = n-1 , index = 0;
        
        while (index != n * n)
        {
            //from top to right
            for (int indexI = top; indexI <= right; indexI++)
            {
                result[top][indexI] = ++index;
            }
            top++;

            //from top to bottom
            for (int col = top; col <= bottom ; col++)
            {
                result[col][right] = ++index;
            }
            right--;
            
            //from right to left
            for (int row = right; row >= left; row--)
            {
                result[bottom][row] = ++index;
            }
            bottom--;
            
            //from bottom to top 
            for (int col = bottom; col >= top; col--)
            {
                result[col][left] = ++index;
            }
            left++;
        }

        return result;
    }
}