public class Solution {

    private static readonly int[][] directions = new int[][] {
        new int[] {1, 0}, new int[] {-1, 0},
        new int[] {0, 1}, new int[] {0, -1}
    };   

    public int NumIslands(char[][] grid) {
        var rows = grid.Length; 
        var cols = grid[0].Length;
        int islands = 0;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (grid[i][j] == '1')
                {
                    Dfs(grid, i, j);
                    islands++;
                }
            }
        }

        return islands;
    }

    private void Dfs(char[][] grid, int row, int col)
    {
        if ( row < 0 || row >= grid.Length || col < 0 || col >= grid[0].Length || grid[row][col] == '0' )
        { 
            return;
        }

        grid[row][col] = '0';
        foreach(var direction in directions)
        {
            Dfs(grid, row + direction[0], col + direction[1]);
        }
    }
}
