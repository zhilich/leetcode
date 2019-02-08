public class Solution {
    public int RemoveElement(int[] nums, int val) {
        var offset = 0;
        
        for (int i = 0; i < nums.Length; i++) {
            nums[i - offset] = nums[i];
            if (nums[i] == val) {
                offset++;
            }
        }
        
        return nums.Length - offset;
    }
}
