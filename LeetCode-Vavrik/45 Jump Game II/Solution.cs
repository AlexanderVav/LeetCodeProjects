public class Solution {
    public int Jump(int[] nums) {
        if (nums.Length <= 1)
            return 0;

        int maxReach = nums[0]; // Maximal erreichbare Position mit einem Sprung
        int steps = nums[0]; // Anzahl der Schritte, die noch gemacht werden können
        int jumps = 1; // Anzahl der Sprünge, beginnt mit 1, da wir mindestens einen Sprung machen müssen

        for (int i = 1; i < nums.Length; i++) {
            if (i == nums.Length - 1)
                return jumps;

            maxReach = Math.Max(maxReach, i + nums[i]); // Aktualisieren der maximal erreichbaren Position

            steps--; // Einen Schritt machen

            if (steps == 0) { // Wenn keine Schritte mehr übrig sind, mache einen Sprung
                jumps++;
                steps = maxReach - i; // Anzahl der verbleibenden Schritte wird aktualisiert
            }
        }

        return jumps;
    }
}