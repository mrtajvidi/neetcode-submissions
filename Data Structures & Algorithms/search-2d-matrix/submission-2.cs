public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        var ROWS = matrix.Length; // rows
        var COLS  = matrix[0].Length;   // columns 

        var top = 0;
        var bot = ROWS  - 1;
        var row = 0;
        while (top <= bot )
        {
            row = (top + bot) / 2;

            if (target > matrix[row][COLS - 1])
            {
                top = row + 1;
            }
            else if (target < matrix[row][0])
            {
                bot = row - 1;
            }
            else 
            {
                break;
            }
        }

        if (!(top <= bot))
        {
            return false;
        }

        var left = 0;
        var right = COLS - 1;

        while (left <= right)
        {
            var mid = (left + right) / 2;

            if (target > matrix[row][mid]) {
                left = mid + 1;
            }
            else if (target < matrix[row][mid]) {
                right = mid - 1;
            }
            else {
                return true;
            }
        }

        return false;
    }
}
