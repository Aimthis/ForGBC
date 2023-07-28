public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        string substring = s[0].ToString();
        string check = string.Empty;
        string LongestSubstring = string.Empty;
        for (int i = 0; substring != s[0..substring.Length].ToString(); i++)
        {
            if (substring[i] != s[i + 1])
                substring += s[i + 1];
            else
            {
                check = s[i + 1].ToString();
                for (int j = i + 1; check != s[i..check.Length].ToString(); j++)
                {
                    if (check[j] != s[j + 1])
                        check += s[j + 1];
                }
                    break;
            }
        }
        if (check.Length > substring.Length && check.Length + substring.Length > s.Length)
            LongestSubstring = check;
        if (check.Length < substring.Length && check.Length + substring.Length > s.Length)
            LongestSubstring = substring;
        return LongestSubstring.Length;
    }
}
