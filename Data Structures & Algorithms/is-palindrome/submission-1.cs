public class Solution
{
    public bool IsPalindrome(string s = "Was it a car or a cat I saw?")
    {
        var stringList = Encoding.UTF8.GetBytes(s.ToLower());
        var range = Enumerable.Range(97, 26).ToList();
        range.AddRange(Enumerable.Range(48, 10).ToList());
        IEnumerable<byte> chars = stringList.Where(x => range.Contains(x));
        var charsList = chars.ToList();
        for (int i = 0; i < charsList.Count; i++)
        {
            if (charsList[i] != charsList[^(i + 1)])
            {
                return false;
            }
        }
        return true;
    }
}