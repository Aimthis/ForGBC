public class Solution {
    public int LengthOfLongestSubstring(string s) {
        string out = s[0];
        string check = s[s.length - 1];
        while(out.length == check.length){
            for(int i = 1; i + 1 < s.length; i++){
                if(out != s[out.length])
                out += s[i];
                for(int j = s.length - 1; j > 0; j--){
                  if(check[j])
                }
            }
        }        
    }
}