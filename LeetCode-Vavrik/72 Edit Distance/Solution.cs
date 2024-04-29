public class Solution {
    public int MinDistance(string word1, string word2) {
        // Erstelle ein 2D-Array dp mit der Größe (word1.Length + 1) x (word2.Length + 1)
        int[,] dp = new int[word1.Length + 1, word2.Length + 1];

        // Initialisiere die erste Zeile und erste Spalte des dp-Arrays
        for (int i = 0; i <= word1.Length; i++) {
            dp[i, 0] = i;
        }

        for (int j = 0; j <= word2.Length; j++) {
            dp[0, j] = j;
        }

        // Fülle das dp-Array
        for (int i = 1; i <= word1.Length; i++) {
            for (int j = 1; j <= word2.Length; j++) {
                if (word1[i - 1] == word2[j - 1]) {
                    dp[i, j] = dp[i - 1, j - 1];
                } else {
                    dp[i, j] = Math.Min(dp[i - 1, j], Math.Min(dp[i, j - 1], dp[i - 1, j - 1])) + 1;
                }
            }
        }

        // Gib den Wert für dp[word1.Length, word2.Length] zurück
        return dp[word1.Length, word2.Length];
    }
}