using System.Collections.Generic;

public class Solution {
    public bool IsValid(string s) {
            var stack = new Stack<char>();

            foreach (var c in s) {
                char expected = 'X';

                switch (c) {
                    case '(':
                    case '{':
                    case '[':
                        stack.Push(c);
                        continue;
                    case ')':
                        expected = '(';
                        break;
                    case '}':
                        expected = '{';
                        break;
                    case ']':
                        expected = '[';
                        break;
                }
                                if (stack.Count == 0) return false;
                var pop = stack.Pop();
                if (pop != expected) return false;
            }

            return stack.Count == 0;
    }
}
