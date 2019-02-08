public class Solution {
    public int StrStr(string haystack, string needle) {
        if (needle.Length == 0) return 0;
        for (int i = 0; i < haystack.Length; i++) {
            var match = true;
            if (i + needle.Length > haystack.Length) return -1;
            for (int j = 0; j < needle.Length; j++) {
                if (haystack[i+j] != needle[j]) {
                    match = false;
                    break;
                }
            }
            if (match) {
                return i;
            }
        }
        return -1;
    }
}
