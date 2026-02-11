public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int i = nums.Length;
        int[] doublenums = new int[2*i];

        for(int z = 0; z < i; z++) {
            doublenums[z] = nums[z];
            doublenums[i+z] = nums[z];
        }
        return doublenums;
    }
}