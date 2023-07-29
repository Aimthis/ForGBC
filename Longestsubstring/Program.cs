public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        string subStr = "";
        int check = 0;
        for (int i = 0; i < s.Length; i++)
        {
            for (int j = i; j < s.Length; j++)
            {
                if (subStr.Length > 0)
                {
                    if (subStr.Contains(s[j].ToString()) == false)
                        subStr += s[j];
                    else
                        break;
                }
                else
                    subStr += s[j];
            }
            if (subStr.Length > check)
                check = subStr.Length;
            subStr = "";
        }
        return check;
    }
}