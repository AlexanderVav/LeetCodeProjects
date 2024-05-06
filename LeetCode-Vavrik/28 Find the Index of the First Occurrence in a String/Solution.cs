public class Solution {
    public int StrStr(string haystack, string needle)
    {
        if (needle.Length == 0) return 0; // Wenn needle leer ist, returne 0

        for (int i = 0; i <= haystack.Length - needle.Length; i++)
        {
            //hier sind die zwei Schleifen wichtig da auch bei mehrern vorkommnissen des einen Buchstaben fehler auftauchen können und so zu anderen Ergebnissen führen können  
            int j;
            for (j = 0; j < needle.Length; j++)
            {
                if (haystack[i + j] != needle[j])
                    break; // Wenn ein Zeichen nicht übereinstimmt, breche die innere Schleife ab
            }
            if (j == needle.Length)
                return i; // Wenn die gesamte Nadel gefunden wurde, returne den Index
        }
        return -1; // Wenn die Nadel nicht gefunden wurde, returne -1
    }
}