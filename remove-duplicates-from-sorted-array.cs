public class Solution {
    public int RemoveDuplicates(int[] nums) {
                    if (nums.Length == 0) return 0;

        
                    var j = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[i - 1]) {
                    nums[j] = nums[i - 1];
                    j++;
                }
            }
            nums[j] = nums[nums.Length - 1];

            return j + 1;
    }
}
