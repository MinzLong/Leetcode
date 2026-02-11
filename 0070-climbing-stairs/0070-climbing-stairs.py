class Solution(object):
    def climbStairs(self, n):
        if n <= 2:
            return n
        
        # Initialize an array to store the number of ways to reach each step
        dp = [0] * (n + 1)
        dp[1] = 1  # There is 1 way to reach the first step
        dp[2] = 2  # There are 2 ways to reach the second step (1+1 or 2)

        # Iterate from step 3 to n, filling in the array based on the sum of the previous two steps
        for i in range(3, n + 1):
            dp[i] = dp[i - 1] + dp[i - 2]

        return dp[n]


