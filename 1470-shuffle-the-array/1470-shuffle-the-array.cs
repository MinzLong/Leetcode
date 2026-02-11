public class Solution {
    public int[] Shuffle(int[] nums, int n) {
        int[] newArray = new int[2*n];
        for(int i=0; i < n; i++){
            newArray[2*i] = nums[i];
            newArray[2*i+1] = nums[n+i];
        }
        return newArray;
    }
}