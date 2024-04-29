public class Solution {
    public int GetWinner(int[] arr, int k)
    {
        bool winnerFound = false;
        int countOfRound = 0;
        var lastWinner = 0;
        var arrayGame = new List<int>(arr);
        var lookup = new Dictionary<int, int>();
        while (!winnerFound)
        {
            
            if (arrayGame[0] < arrayGame[1])
            {
                var loser = arrayGame[0];
                arrayGame.RemoveAt(0);
                arrayGame.Add(loser);
                lastWinner = arrayGame.First();
                if (!lookup.TryAdd(lastWinner, 0)) 
                    lookup[arrayGame.First()] = 1;
            }
            else
            {
                var loser = arrayGame[1];
                arrayGame.RemoveAt(1);
                arrayGame.Add(loser);
                lastWinner = arrayGame.First();
                if (!lookup.TryAdd(lastWinner, 1)) 
                    lookup[arrayGame.First()] += 1;
                if (countOfRound - arrayGame.Count() == 0)
                    return arrayGame.First();
            }
            countOfRound++;

            if (arrayGame.First() == lastWinner && lookup[arrayGame.First()] == k)
            {
                Console.WriteLine($" {arrayGame.First()} has won {k}");
                winnerFound = true;
            }
        }

        return arrayGame.First();
    }
}