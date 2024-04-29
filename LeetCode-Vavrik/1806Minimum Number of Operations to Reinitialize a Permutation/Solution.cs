public class Solution {
    public int ReinitializePermutation(int n)
    {
        int count = 0;
        int[] perm = new int[n];
        for (int i = 0; i < n; i++)
            perm[i] = i;
        
        int[] arr = new int[n];
        while (true)
        {
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                    arr[i] = perm[i / 2];
                else
                    arr[i] = perm[n / 2 + (i - 1) / 2];
            }
            count++;
            bool equal = true;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] != i)
                {
                    equal = false;
                    break;
                }
            }
            if (equal) break;
            for (int i = 0; i < n; i++)
                perm[i] = arr[i];
        }
        
        return count;
    }
}