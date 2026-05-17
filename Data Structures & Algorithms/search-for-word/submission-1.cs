public class Solution {
    public bool Exist(char[][] board, string word) {
        
        for (int r = 0; r < board.Length; r++)
        {
            for (int c = 0; c < board[0].Length; c++)
            {
                if (Dfs(board, r, c, 0, word))
                {
                    return true;
                }
            }
        }
        return false;
    }

    private bool Dfs(char[][] board, int row, int col, int i, string word)
    {
        if (i == word.Length)
        {
            return true;
        }

        if (row < 0 || col < 0 || row >= board.Length || col >= board[0].Length || board[row][col] == '0' || board[row][col] != word[i])
        {
            return false;
        }        

        board[row][col] = '0';
        bool res = Dfs(board, row + 1, col, i + 1, word)
                || Dfs(board, row - 1, col, i + 1, word)
                || Dfs(board, row, col + 1, i + 1, word)
                || Dfs(board, row, col - 1, i + 1, word);

    
        // back tracking
        board[row][col] = word[i];
        return res;        
    }
}
