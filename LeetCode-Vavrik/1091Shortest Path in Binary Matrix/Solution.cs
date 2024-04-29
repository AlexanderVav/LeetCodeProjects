using System;
using System.Collections.Generic;

public class Solution
{
    public int ShortestPathBinaryMatrix(int[][] grid)
    {
        int n = grid.Length;
        if (grid[0][0] == 1 || grid[n - 1][n - 1] == 1)
            return -1;

        int[][] directions = new int[][] {
            new int[] { -1, -1 }, // top-left
            new int[] { -1, 0 },  // top
            new int[] { -1, 1 },  // top-right
            new int[] { 0, -1 },  // left
            new int[] { 0, 1 },   // right
            new int[] { 1, -1 },  // bottom-left
            new int[] { 1, 0 },   // bottom
            new int[] { 1, 1 }    // bottom-right
        };

        Queue<int[]> queue = new Queue<int[]>();
        queue.Enqueue(new int[] { 0, 0 });
        grid[0][0] = 1; // Mark as visited

        int steps = 1;

        while (queue.Count > 0)
        {
            int size = queue.Count;
            for (int i = 0; i < size; i++)
            {
                int[] current = queue.Dequeue();
                int x = current[0];
                int y = current[1];
                if (x == n - 1 && y == n - 1)
                    return steps;

                foreach (int[] dir in directions)
                {
                    int newX = x + dir[0];
                    int newY = y + dir[1];

                    if (newX >= 0 && newX < n && newY >= 0 && newY < n && grid[newX][newY] == 0)
                    {
                        queue.Enqueue(new int[] { newX, newY });
                        grid[newX][newY] = 1; // Mark as visited
                    }
                }
            }
            steps++;
        }

        return -1;
    }
}