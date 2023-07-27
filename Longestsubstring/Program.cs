public class Solution {
    public int LengthOfLongestSubstring(string s) {
        string substring = string.Empty;                                                         
        string LongestSubstring = string.Empty;
        for(int end = 0; end < s.Length; end ++){
            for(int i = 0; i < s.Length; i++){
                if(substring[i] != s[substring.Length])
                    substring += s[substring.Length];
            }
            if(substring.Length < s.Length){
                string check = substring.Substring(0,substring.Length - 1);
                for(int j = substring.Length + 1; j < s.Length; j++){
                    if(check[j - 1] != s[j])
                        check += s[j];
                }
            if(substring.Length > check.Length)
                LongestSubstring = substring;
            else
                LongestSubstring = check;
            }
        }        
        return LongestSubstring.Length;
    }
}