public class Solution {
    public int MinDeletionSize(string[] strs) {
        int n = strs.Length;
        int m = strs[0].Length;

        int[] dp = new int[m];
        Array.Fill(dp, 1);

        for(int j = 0; j < m; j++) {
            for(int i = 0; i < j; i++){
                if(CanFollow(strs,i,j))
                dp[j] = Math.Max(dp[j], dp[i]+1);
            }   
        }
        int maxKeep = dp.Max();
        return m - maxKeep;
    }

        public bool CanFollow(string[] strs, int i, int j){
        for(int r = 0; r < strs.Length; r++){
            if(strs[r][i] > strs[r][j])
            return false;
            }
        return true;
        }
    }