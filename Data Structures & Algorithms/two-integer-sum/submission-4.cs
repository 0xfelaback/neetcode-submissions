public class Solution
{
    public int[] TwoSum(int[]? nums = null, int target = 10)
    {
        if (nums is null) nums = [3, 2, 3];
        int[] result = [];
        Dictionary<int, int> hashtable = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            hashtable.Add(i, nums[i]);
            int x = target - nums[i];
            //int xPositive = Math.Abs(x);
            int index = Array.IndexOf(nums, x);
            if (index == -1)
            {
                continue;
            }
            else
            {
                result = [index, i];
            }

        }
        return result;
    }
    }

