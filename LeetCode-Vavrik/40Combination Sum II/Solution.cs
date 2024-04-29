public class Solution {
    public IList<IList<int>> CombinationSum2(int[] candidates, int target) {
        IList<IList<int>> result = new List<IList<int>>();
        Array.Sort(candidates);  // Sortiere das Array, um Duplikate effektiv zu behandeln
        FindCombinations(candidates, target, 0, new List<int>(), result);
        return result;
    }

    private void FindCombinations(int[] candidates, int target, int start, List<int> currentList, IList<IList<int>> result) {
        // Basisfall: Wenn das Ziel erreicht ist, füge die Kombination zum Ergebnis hinzu
        if (target == 0) {
            result.Add(new List<int>(currentList));//hier neue Kopjie wie  im CopyTo nur hier mti neuer Referenz und so kein Problem mit veränderung  soäter   
            return;
        }

        for (int i = start; i < candidates.Length && candidates[i] <= target; i++) {
            // Überspringe Duplikate
            if (i > start && candidates[i] == candidates[i - 1]) {
                continue;
            }

            // Füge die aktuelle Zahl zur Kombination hinzu
            currentList.Add(candidates[i]);

            // Rekursiver Aufruf mit dem aktualisierten Ziel und Startindex
            FindCombinations(candidates, target - candidates[i], i + 1, currentList, result);

            // Entferne das letzte Element, um die Kombination für den nächsten Durchlauf zurückzusetzen
            currentList.RemoveAt(currentList.Count - 1);
        }
    }
}