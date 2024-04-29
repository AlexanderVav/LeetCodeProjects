public class Solution {
    public int[][] Merge(int[][] intervals)
    {
        var result = new List<int[]>();
        foreach (var currentArray in intervals)
        {
            if (CheckResult(result, currentArray))
                continue;
            var tryIn = TrySet(intervals, currentArray, result);
            if (!tryIn)
            {
                result.Add(currentArray);
            }

        }

        return result.ToArray();
    }

    private bool TrySet(int[][] intervals, int[] currentArray, List<int[]>result)
    {
        bool isInside = false;
        foreach (var other in intervals)
        {
            if (CheckResult(result, other))
                continue;
            int minFront = 0;
            int minBack = 0;
            if (currentArray.First() == other.First() && currentArray.Last() == other.Last())
                continue;
            if (currentArray.First() <= other.First() && other.First() <= currentArray.Last() && !isInside)
            {
                isInside = true;
                minFront = currentArray.First() < other.Last() ? currentArray.First() : other.Last();
                if (other.Last() > currentArray.Last())
                {
                    minBack = other.Last();
                }
                else
                {
                    minBack = currentArray.Last();
                }
            }

            if (other.Last() >= currentArray.Last() && other.First() <= currentArray.First() && !isInside)
            {
                isInside = true;
                minFront = currentArray.First() < other.First() ? currentArray.First() : other.First();
                minBack = currentArray.Last() < other.Last() ? other.Last() : currentArray.Last();
            }

            if (currentArray.First() >= other.First() && other.Last() <= currentArray.Last() && other.Last() >= currentArray.First())
            {
                isInside = true;
                minFront = currentArray.First() < other.First() ? currentArray.First() : other.First();
                minBack = currentArray.Last() > other.Last() ? currentArray.Last() : other.Last();
            }
            //andersrum 
            if (isInside)
            {
                result.Add(new []{minFront, minBack});
                break;
            } 
        }

        return isInside;
    }

    private bool CheckResult(List<int[]> result, int[] searched)
    {
        if (result.Count == 0)
            return false;
        bool toBeReturned = false;
        for (var index = 0; index < result.Count; index++)
        {
            var current = result[index];
            if (searched.First() == current.First() && searched.Last() == current.Last()
                || (searched.First() == current.First() && searched.Last() == current.First())
                || (searched.First() == current.Last() && searched.Last() == current.Last()))
            {
                return true;
            }

            if (searched.First() > current.First() &&
                searched.First() < current.Last() &&
                current.Last() < searched.Last())
            {
                result[index][1] = searched.Last();
                return true;
            }

            if (searched.Last() < current.Last() &&
                searched.First() < current.First() &&
                searched.Last() > current.First())
            {
                result[index][0] = searched.First();
                return true;
            }

            if (searched.Last() == current.First() && searched.First() < current.First())
            {
                result[index][0] = searched.First();
                return true;
            }
            
            if (searched.Last() == current.First() && searched.Last() > current.Last())
            {
                result[index][1] = searched.Last();
                return  true;
            }

            if (searched.Last() == current.Last() && searched.First() < current.First())
            {
                result[index][0] = current.First();
                return true;
            }

            if (searched.First() == current.Last() && searched.Last() > current.Last())
            {
                result[index][1] = searched.Last();
                return true;
            }
        }

        return toBeReturned;
    }
}