public class Solution {
    public int NumMagicSquaresInside(int[][] grid) {
        int rows = grid.Length;
        int cols = grid[0].Length;
        int count = 0;

        if(rows<3 || cols<3) return 0;
        for(int i=0; i<=rows-3; i++){
            for(int j=0; j<=cols-3; j++){
                if(IsMagic(grid,i,j)){
                    count++;
                }
            }
        }
        return count;
    }

    public bool IsMagic(int[][] grid, int row, int col){
        if(grid[row+1][col+1] != 5) return false;
        if(!Check1to9Distinct(grid,row,col)) return false;
        int s = grid[row][col]+ grid[row][col+1]+ grid[row][col+2];

        for(int i = 0; i<3; i++)
            if(grid[row+i][col]+ grid[row+i][col+1]+ grid[row+i][col+2] != s)
                return false;
        
        for(int j = 0; j<3; j++)
            if(grid[row][col+j]+ grid[row+1][col+j]+ grid[row+2][col+j] != s)
                return false;
        
        if(grid[row][col]+grid[row+1][col+1]+grid[row+2][col+2] != s) return false;
        if(grid[row+2][col]+grid[row+1][col+1]+grid[row][col+2] != s) return false;

        return true;
    }

    public bool Check1to9Distinct(int[][] grid, int row, int col){
        bool[] seen = new bool[10];

        for(int i=row;i<row+3;i++){
            for(int j=col;j<col+3;j++){
                int v = grid[i][j];

                if(v<1 || v>9) return false;
                if(seen[v]) return false;

                seen[v] = true;
            }
        }
        return true;
    }
}