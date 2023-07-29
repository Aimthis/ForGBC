public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        string subStr = s[0].ToString();
        string check = string.Empty;
        for (int i = 0; i < s.Length; i++)
        {
            if (subStr.Contains(s[i].ToString()) == false)
                subStr += s[i];
            else
            {
                for (int j = i; j < s.Length; j++)
                {
                    i = j;
                    if (check.Contains(s[j].ToString()) == false)
                    check += s[j];
                }
            }
            if (check.Length > subStr.Length)
                break;
            else{
                check = subStr;
                subStr = string.Empty;
            }
        }
        if (check.Length >= subStr.Length)
            return check.Length;
        else if (check.Length < subStr.Length)
            return subStr.Length;
        else
            return 0;
    }
}