public class Solution {
    public bool IsPalindrome(int x) {
            if (x < 0) return false;

            long y = 0;
            int z = x;

            while (x != 0)
            {
                y = y * 10;

                var d = x % 10;

                y += d;

                x = x / 10;
            }

            return z == y;
    }
}
