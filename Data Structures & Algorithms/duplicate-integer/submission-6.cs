public class Solution
{
    public bool hasDuplicate(int[]? nums)
    {
        HashSet<int> checkList = new HashSet<int>();
        foreach (var item in nums)
        {
            if (!checkList.Add(item)) return true;
        }
        return false;
    }
}