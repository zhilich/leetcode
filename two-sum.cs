public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        for (int num1 = 0; num1 < nums.Length; num1++) {
            for (int num2 = num1 + 1; num2 < nums.Length; num2++) {
                if (nums[num1] + nums[num2] == target) {
                    return new [] { num1, num2 };
                }
            }
        }
        return new int[] {0, 0};
    }
}
