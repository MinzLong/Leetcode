public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int i = nums.Length;
        int c = 0;
        int m = 0;
        for(int z = 0; z<i; z++){
            if(nums[z] == 1){
                c++ ;
                if(c>m){
                    m = c;
                }
            }   
            else{
                c=0;
            }
            }
            return m;
        }
    }