public class Solution
{
    public bool IsPalindrome(string s = "Was it a car or a cat I saw?")
    {
        List<char> charList = [];
        charList.AddRange(s.ToLower().Where(b => char.IsLetterOrDigit(b)));
        for (int i = 0; i < charList.Count; i++)
        {
            if (charList[i] != charList[^(i + 1)])
            {
                return false;
            }
        }
        return true;
    }
}