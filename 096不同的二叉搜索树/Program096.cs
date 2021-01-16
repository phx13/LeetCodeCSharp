using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _096不同的二叉搜索树
{
    //给定一个整数 n，求以 1 ... n 为节点组成的二叉搜索树有多少种？

    //示例:

    //输入: 3
    //输出: 5
    //解释:
    //给定 n = 3, 一共有 5 种不同结构的二叉搜索树:

    //   1         3     3      2      1
    //    \       /     /      / \      \
    //     3     2     1      1   3      2
    //    /     /       \                 \
    //   2     1         2                 3

    class Program096
    {
        static void Main(string[] args)
        {
            var n = 3;
            Console.WriteLine(NumTrees(n));
            Console.ReadKey();
        }
        public static int NumTrees(int n)
        {
            //G(n)G(n): 长度为 nn 的序列能构成的不同二叉搜索树的个数。

            //F(i, n)F(i, n): 以 ii 为根、序列长度为 nn 的不同二叉搜索树个数(1 \leq i \leq n)(1≤i≤n)。

            //举例而言，创建以 33 为根、长度为 77 的不同二叉搜索树，整个序列是 [1, 2, 3, 4, 5, 6, 7][1,2,3,4,5,6,7]，我们需要从左子序列 [1, 2][1,2] 构建左子树，从右子序列 [4, 5, 6, 7][4,5,6,7] 构建右子树，然后将它们组合（即笛卡尔积）。

            //对于这个例子，不同二叉搜索树的个数为 F(3, 7)F(3, 7)。我们将[1, 2][1, 2] 构建不同左子树的数量表示为 G(2)G(2), 从[4, 5, 6, 7][4, 5, 6, 7] 构建不同右子树的数量表示为 G(4)G(4)，注意到 G(n)G(n) 和序列的内容无关，只和序列的长度有关。于是，F(3, 7) = G(2) \cdot G(4)F(3, 7) = G(2)⋅G(4)。

            //F(i,n)=G(i−1)⋅G(n−i)

            int[] G = new int[n + 1];
            G[0] = G[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    G[i] += G[j - 1] * G[i - j];
                }
            }
            return G[n];
        }
    }
}
