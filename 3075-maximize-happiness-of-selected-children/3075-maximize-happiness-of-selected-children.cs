public class Solution {
    public long MaximumHappinessSum(int[] happiness, int k) {
        Array.Sort(happiness);
        long sum = 0;
        int n = happiness.Length;

        for(int i =0; i<k; i++){
            int val = happiness[n - 1 - i] - i;
            if (val <= 0) break;
            sum += val;
        }
        return sum;
    }
}