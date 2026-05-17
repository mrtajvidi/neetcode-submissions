public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        var ROWS = matrix.Length;
        var COLS = matrix[0].Length;

        int top = 0, bot = ROWS - 1;
        
        var row = 0;
        while (top <= bot)
        {
            row = top + (bot - top) / 2;
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

        Console.WriteLine($"Found the mid row: {row}");

        // if (!(top <= bot)) {
        //     return false;
        // }

        int l = 0, r = COLS - 1;
        
        while (l <= r)
        {
            var m = l + (r - l)/2;

            if (target > matrix[row][m])
            {
                l = m + 1;
            }
            else if (target < matrix[row][m])
            {
                r = m - 1;
            }
            else 
            {
                return true;
            }
        }
        return false;
    }
}
