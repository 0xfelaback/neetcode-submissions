public class Solution
{
    List<int> checkList = [];
    public bool hasDuplicate(int[]? nums = null)
    {
        if (nums is null) nums = [1, 2, 3, 3];
        foreach (var item in nums)
        {
            if (checkList.Contains(item))
            {
                return true;
            }
            else
            {
                checkList.Add(item);
            }
        }
        return false;
    }
}