public class Solution {
    public int MaxAreaOfIsland(int[][] grid) {
        var m = grid.Length;
        var n = grid[0].Length;
        var maxArea = 0;

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (grid[i][j] == 1)
                {
                    maxArea = Math.Max(maxArea, DFS(i, j, grid));
                }
            }
        }
        return maxArea;
    }

    private int DFS(int r, int c, int[][] grid)
    {
        var m = grid.Length;
        var n = grid[0].Length;

        if (r < 0 || r >= m || c < 0 || c >= n || grid[r][c] == 0) return 0;

        var area = 1;
        grid[r][c] = 0;
        var rows = new int[4] {1, -1, 0, 0};
        var cols = new int[4] {0, 0, 1, -1};

        for (int i = 0; i < 4; i++)
        {
            area += DFS(r + rows[i], c + cols[i], grid);
        }
        return area;
    }
}
