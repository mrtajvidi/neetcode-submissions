public class Solution {
    public bool IsValidSudoku(char[][] board) {
         HashSet<string> seen = new HashSet<string>();

        for (int i = 0; i < 9; i++) {
            for (int j = 0; j < 9; j++) {
                char num = board[i][j];
                if (num != '.') {
                    string rowKey = $"{num} in row {i}";
                    string colKey = $"{num} in col {j}";
                    string boxKey = $"{num} in box {i/3}-{j/3}";

                    if (seen.Contains(rowKey) || seen.Contains(colKey) || seen.Contains(boxKey)) {
                        return false;
                    }

                    seen.Add(rowKey);
                    seen.Add(colKey);
                    seen.Add(boxKey);
                }
            }
        }
        return true;
    }
}
