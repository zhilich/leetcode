public class Solution {
    public int Reverse(int x) {
            int y = 0;

            while (x != 0) {
                if ((long)y * 10 > int.MaxValue || (long)y * 10 < int.MinValue)
                    return 0;
                y = y * 10;

                var d = x % 10;

                if ((long)y + d > int.MaxValue || (long)y + d < int.MinValue)
                    return 0;
                y += d;

                x = x / 10;
            }

            return y;
    }
}
