using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_programming
{
    class Solution
    {
        public int CountBattleships(char[,] board)
        {
            int m = board.GetLength(0), n = board.GetLength(1), result = 0, i = 0, j = 0;
            if ((m == 0) || (n == 0))
            {
                return result;
            }
            for (i = 0;i < m;i++)
            {
                for (j = 0;j < n; j++)
                {
                    if ((board[i, j] == 'X') && ((i == 0) || (board[i - 1, j] == '.')) && ((j == 0) || (board[i, j - 1] == '.')))
                    {
                        result += 1;
                    }
                }
            }
            return result;
        }
    }
    class BattleshipsinaBoard
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            char[,] board = new char[,]{ { 'X', '.', '.', 'X' }, { '.', '.', '.', 'X' }, { '.', '.', '.', 'X' } };
            Console.WriteLine(solution.CountBattleships(board));
            Console.ReadKey();
        }
    }
}
