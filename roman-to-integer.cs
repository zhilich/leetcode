public class Solution {
    public int RomanToInt(string s) {
                    s = s.Replace("IV", "IIII");
            s = s.Replace("IX", "VIIII");
            s = s.Replace("XL", "XXXX");
            s = s.Replace("XC", "LXXXX");
            s = s.Replace("CD", "CCCC");
            s = s.Replace("CM", "DCCCC");

            int value = 0;

            foreach (var c in s) {
                switch (c) {
                    case 'I':
                        value += 1;
                        break;
                    case 'V':
                        value += 5;
                        break;
                    case 'X':
                        value += 10;
                        break;
                    case 'L':
                        value += 50;
                        break;
                    case 'C':
                        value += 100;
                        break;
                    case 'D':
                        value += 500;
                        break;
                    case 'M':
                        value += 1000;
                        break;
                    default:
                        throw new Exception();
                }
            }

            return value;
    }
}
