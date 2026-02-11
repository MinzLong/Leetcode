public class Solution {
    public int CountNegatives(int[][] grid) {
        int m = grid.Length;
        int n = grid[0].Length;

        int row = m - 1;
        int col = 0;
        int count = 0;

        while (row >= 0 && col < n) {
            if (grid[row][col] < 0) {
                count += (n - col);
                row--; 
            } else {
                col++; 
            }
        }
        return count;
    }
}
