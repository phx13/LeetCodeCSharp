using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _070爬楼梯
{
    //假设你正在爬楼梯。需要 n 阶你才能到达楼顶。

    //每次你可以爬 1 或 2 个台阶。你有多少种不同的方法可以爬到楼顶呢？

    //注意：给定 n 是一个正整数。

    //示例 1：

    //输入： 2
    //输出： 2
    //解释： 有两种方法可以爬到楼顶。
    //1.  1 阶 + 1 阶
    //2.  2 阶
    //示例 2：

    //输入： 3
    //输出： 3
    //解释： 有三种方法可以爬到楼顶。
    //1.  1 阶 + 1 阶 + 1 阶
    //2.  1 阶 + 2 阶
    //3.  2 阶 + 1 阶

    class Program070
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ClimbStairs(3));
            Console.ReadKey();
        }
        public static int ClimbStairs(int n)
        {
            var reslist = new List<int>();
            for (int i = 0; i < n + 1; i++)
            {
                reslist.Add(0);
            }
            reslist[0] = 1;
            for (int i = 1; i < n + 1; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (i - j <= 2)
                    {
                        reslist[i] += reslist[j];
                    }
                }
            }
            return reslist.Last();
        }
    }
}
