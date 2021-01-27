using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _062不同路径
{
    //一个机器人位于一个 m x n 网格的左上角 （起始点在下图中标记为 “Start” ）。

    //机器人每次只能向下或者向右移动一步。机器人试图达到网格的右下角（在下图中标记为 “Finish” ）。

    //问总共有多少条不同的路径？



    //示例 1：


    //输入：m = 3, n = 7
    //输出：28
    //示例 2：

    //输入：m = 3, n = 2
    //输出：3
    //解释：
    //从左上角开始，总共有 3 条路径可以到达右下角。
    //1. 向右 -> 向下 -> 向下
    //2. 向下 -> 向下 -> 向右
    //3. 向下 -> 向右 -> 向下
    //示例 3：

    //输入：m = 7, n = 3
    //输出：28
    //示例 4：

    //输入：m = 3, n = 3
    //输出：6


    //提示：

    //1 <= m, n <= 100
    //题目数据保证答案小于等于 2 * 109

    class Program062
    {
        static void Main(string[] args)
        {
            var m = 3;
            var n = 7;
            Console.WriteLine(UniquePaths(m, n));
            Console.ReadKey();
        }
        public static int UniquePaths(int m, int n)
        {
            var res = 0;
            if (m == 0 && n == 0)
            {
                return res;
            }

            ////DFS
            //var tempM = 0;
            //var tempN = 0;
            //return DFS(m, n, tempM, tempN, res);

            //动态规划
            //f(i,j)=f(i−1,j)+f(i,j−1)
            var grid = new int[m][];
            for (int i = 0; i < m; i++)
            {
                grid[i] = new int[n];
            }
            for (int i = 0; i < m; i++)
            {
                grid[i][0] = 1;
            }
            for (int j = 0; j < n; j++)
            {
                grid[0][j] = 1;
            }
            for (int i = 1; i < m; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    grid[i][j] = grid[i - 1][j] + grid[i][j - 1];
                }
            }
            return grid[m - 1][n - 1];
        }

        private static int DFS(int m, int n, int tempM, int tempN, int res)
        {
            if (tempM == m - 1 && tempN == n - 1)
            {
                return 1;
            }
            if (tempM == m || tempN == n)
            {
                return 0;
            }

            return DFS(m, n, tempM + 1, tempN, res) + DFS(m, n, tempM, tempN + 1, res);
        }
    }
}
