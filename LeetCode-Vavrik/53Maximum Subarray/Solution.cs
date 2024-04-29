public class Solution
{
    public int MaxSubArray(int[] nums) {
        int maxEnding = nums[0]; // Zeiger, der auf das aktuelle Ende des Teilarrays zeigt
        int max = nums[0]; // Zeiger, der auf das aktuell größte Teilarray zeigt
        int left = 0; // Linker Zeiger, um das aktuelle Teilarray zu verfolgen
        int right = 0; // Rechter Zeiger, um das aktuelle Teilarray zu verfolgen
        for (int i = 1; i < nums.Length; i++) {
            // Überprüfe, ob es besser ist, ein neues Teilarray zu beginnen oder das aktuelle zu erweitern
            if (nums[i] > maxEnding + nums[i]) {
                // Ein neues Teilarray beginnen
                maxEnding = nums[i];
                left = i; // Linken Zeiger aktualisieren
            } else {
                // Das aktuelle Teilarray erweitern
                maxEnding = maxEnding + nums[i];
            }
            // Überprüfe, ob das aktuelle Teilarray das bisher größte ist
            if (maxEnding > max) {
                max = maxEnding;
                right = i; // Rechten Zeiger aktualisieren
            }
        }
        // Ausgabe der Indizes des maximalen Teilarrays
        Console.WriteLine("Max Subarray found between indices " + left + " and " + right);
        return max; // Rückgabe des maximalen Teilarrays
    }
}