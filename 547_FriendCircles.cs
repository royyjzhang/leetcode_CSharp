using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_programming
{
    class UnionFind
    {
        private int numOfSets = 0;
        private int[] parent, rank;
        public UnionFind(int n)
        {
            numOfSets = n;
            parent = new int[n];
            rank = new int[n];
            for (int i= 0; i< n;i++)
            {
                parent[i] = i;
            }
        }
        public int find(int p)
        {
            while (p != parent[p])
            {
                parent[p] = parent[parent[p]];
                p = parent[p];
            }
            return p;
        }
        public void union(int p, int q)
        {
            int rootP = find(p);
            int rootQ = find(q);
            if (rootP == rootQ)
                return;
            if (rank[rootQ] > rank[rootP])
            {
                parent[rootP] = rootQ;
            }
            else
            {
                parent[rootQ] = rootP;
                if (rank[rootP] == rank[rootQ])
                {
                    rank[rootP]++;
                }
            }
            numOfSets--;
        }

        public int nums()
        {
            return numOfSets;
        }
    }
    class Solution
    {
        public int FindCircleNum(int[,] M)
        {
            int n = M.GetLength(0);
            UnionFind sets = new UnionFind(n);
            for (int i = 0; i < n - 1;i++)
            {
                for (int j = i + 1; j < n;j++)
                {
                    if (M[i,j] == 1)
                        sets.union(i, j);
                }
            }
            return sets.nums();
        }
    }
    class FriendCircles
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[,] M = { { 1, 1, 0 }, { 1, 1, 1 }, { 0, 1, 1 } };
            Console.WriteLine(solution.FindCircleNum(M));
            Console.ReadKey();
        }
    }
}
