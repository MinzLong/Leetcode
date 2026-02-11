using System;

public class Solution
{
    public int MaxDotProduct(int[] nums1, int[] nums2)
    {
        int n = nums1.Length, m = nums2.Length;
        long NEG = -(long)1e18; // âm vô cùng an toàn

        // prev[j] = dp của hàng i-1 tại cột j
        long[] prev = new long[m];
        for (int j = 0; j < m; j++) prev[j] = NEG;

        for (int i = 0; i < n; i++)
        {
            long[] cur = new long[m];
            for (int j = 0; j < m; j++) cur[j] = NEG;

            for (int j = 0; j < m; j++)
            {
                long pair = (long)nums1[i] * nums2[j];

                // dùng cặp (i,j):
                // - bắt đầu mới bằng pair
                // - hoặc nối vào dp[i-1][j-1] nếu tồn tại
                long use = pair;
                if (i > 0 && j > 0 && prev[j - 1] != NEG)
                    use = Math.Max(use, prev[j - 1] + pair);

                long best = use;

                // bỏ nums1[i]
                if (i > 0) best = Math.Max(best, prev[j]);

                // bỏ nums2[j]
                if (j > 0) best = Math.Max(best, cur[j - 1]);

                cur[j] = best;
            }

            prev = cur;
        }

        return (int)prev[m - 1];
    }
}
