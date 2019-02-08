public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if (strs.Length == 1) return strs[0];
                    if (strs.Length == 0) return "";
        StringBuilder substr = new StringBuilder();
        for (int i = 0; ; i++) {            
            for (var j = 1; j < strs.Length; j++) {                
                if (strs[j].Length <= i || strs[j-1].Length <= i || strs[j][i] != strs[j-1][i]) {
                    return substr.ToString();
                }
            }
            substr.Append(strs[0][i]);
        }
    }
}
