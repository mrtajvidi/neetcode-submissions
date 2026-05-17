public class Solution {
    public int NumIslands(char[][] grid) {
        var rows = grid.Length;
        var cols = grid[0].Length;
        var numOfIslands = 0;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (grid[i][j] == '1')
                {
                    numOfIslands++;
                    Dfs(grid, i, j, rows, cols);
                }
            }
        }

        return numOfIslands;
    }

    private void Dfs(char[][] grid, int i, int j, int rows, int cols)
    {
        if (i < 0 || i >= rows || j < 0 || j >= cols || grid[i][j] == '0')
        {
            return;
        }

        grid[i][j] = '0';
        Dfs(grid, i + 1, j, rows, cols);
        Dfs(grid, i - 1, j, rows, cols);
        Dfs(grid, i, j - 1, rows, cols);
        Dfs(grid, i, j + 1, rows, cols);
    }
}
