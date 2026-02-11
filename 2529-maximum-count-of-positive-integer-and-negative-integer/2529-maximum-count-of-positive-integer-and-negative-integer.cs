public class Solution {
    public int MaximumCount(int[] nums) {
        int m = nums.Length;
        int p = 0;
        int n = 0;
        for(int i =0; i<m; i++){
            if(nums[i] >0){
                p++;
            }
            if(nums[i] <0){
                n++;
            }
        }
        return Math.Max(p,n);
    }
}