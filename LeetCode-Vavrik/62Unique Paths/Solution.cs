public class Solution {
    public int UniquePaths(int m, int n) {
        // Starte die rekursive Funktion mit Startpunkt (0, 0) und Ziel (m-1, n-1)
        return CountPaths(0, 0, m - 1, n - 1);
    }

    private int CountPaths(int x, int y, int targetX, int targetY) {
        // Basisfall: Wenn wir das Ziel erreicht haben, gibt es einen Weg
        if (x == targetX && y == targetY) {
            return 1;
        }

        // Initialisiere den Zähler für die Wege von diesem Punkt
        int paths = 0;

        // Bewege dich nach rechts, wenn du innerhalb der Grenzen bist
        if (x < targetX) {
            paths += CountPaths(x + 1, y, targetX, targetY);
        }

        // Bewege dich nach unten, wenn du innerhalb der Grenzen bist
        if (y < targetY) {
            paths += CountPaths(x, y + 1, targetX, targetY);
        }

        // Gib die Anzahl der Wege zurück
        return paths;
    }
}