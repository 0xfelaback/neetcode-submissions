public class Solution
{
    public bool hasDuplicate(int[]? nums = null)
    {
        HashSet<int> checkList = new HashSet<int>();
        if (nums is null) nums = [1, 2, 3, 3];
        foreach (var item in nums)
        {
            if (!checkList.Add(item)) return true;
        }
        return false;
    }
}