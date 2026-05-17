public class Solution {
    private int rows, cols;
    private HashSet<(int, int)> visit;

    public int IslandPerimeter(int[][] grid) {
        rows = grid.Length;
        cols = grid[0].Length;
        visit = new HashSet<(int, int)>();

        int Dfs(int i, int j) {
            if (i < 0 || j < 0 || i >= rows || j >= cols || grid[i][j] == 0) {
                return 1;
            }
            if (visit.Contains((i, j))) {
                return 0;
            }

            visit.Add((i, j));
            int perim = Dfs(i, j + 1) + Dfs(i + 1, j) + Dfs(i, j - 1) + Dfs(i - 1, j);
            return perim;
        }

        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                if (grid[i][j] == 1) {
                    return Dfs(i, j);
                }
            }
        }

        return 0;
    }
}