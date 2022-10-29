using System;

namespace WordSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static public bool Exist(char[][] board, string word) {
            for(int i=0; i < board.Length; i++)
                for(int j=0; j < board[0].Length; j++)
                {
                    if(board[i][j] == word[0] && dfs(board, word, i, j, 0))
                        return true;
                }
            return false;
        }
    
        static bool dfs(char[][] board, string word, int i, int j, int idx)
        {
            //base case
            if(idx == word.Length)
                return true;

            if(i < 0 || i >= board.Length || j < 0 || j >= board[0].Length || board[i][j] != word[idx])
                return false;

            char tmp = board[i][j];
            board[i][j] = ' ';
            
            bool found = dfs(board, word, i+1, j, idx + 1) ||
                        dfs(board, word, i-1, j, idx + 1) ||
                        dfs(board, word, i, j+1, idx + 1) ||
                        dfs(board, word, i, j-1, idx + 1);
            board[i][j] = tmp;
            
            return found;
        }
    }
}
