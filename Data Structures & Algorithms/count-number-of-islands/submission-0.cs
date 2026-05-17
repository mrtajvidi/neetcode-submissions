public class Solution {
    public int NumIslands(char[][] grid) {
        var m = grid.Length;
        var n = grid[0].Length;

        var count = 0;
        for (int i = 0; i < m; i++)
            for (int j = 0; j < n; j++)
            {
                if (grid[i][j] == '1')
                {
                    count++;
                    DFS(i, j, grid, m, n);  
                }              
            }
        return count;
    }

    private void DFS(int r, int c, char[][] grid, int m, int n)
    {
        if (r < 0 || r >= m || c < 0 || c >= n || grid[r][c] == '0')
            return;
        
        grid[r][c] = '0';
        DFS(r + 1, c, grid, m, n);
        DFS(r - 1, c, grid, m, n);
        DFS(r, c + 1, grid, m, n);
        DFS(r, c - 1, grid, m, n);
    }

}
