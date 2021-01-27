using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _647回文子串
{
    //给定一个字符串，你的任务是计算这个字符串中有多少个回文子串。

    //具有不同开始位置或结束位置的子串，即使是由相同的字符组成，也会被视作不同的子串。



    //示例 1：

    //输入："abc"
    //输出：3
    //解释：三个回文子串: "a", "b", "c"
    //示例 2：

    //输入："aaa"
    //输出：6
    //解释：6个回文子串: "a", "a", "a", "aa", "aa", "aaa"


    //提示：

    //输入的字符串长度不会超过 1000 。

    class Program647
    {
        static void Main(string[] args)
        {
            var s = "aaa";
            Console.WriteLine(CountSubstrings(s));
            Console.ReadKey();
        }
        public static int CountSubstrings(string s)
        {
            //dp[i][j]表示s[i,j]是否是回文字符串
            //需要满足的条件是s[i]=s[j]，并且j-i<2或dp[i+1][j-1]=true
            var dp = new bool[s.Length][];
            for (int i = 0; i < s.Length; i++)
            {
                dp[i] = new bool[s.Length];
            }
            var ans = 0;

            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (s[j] == s[i] && (i - j < 2 || dp[j + 1][i - 1]))
                    {
                        dp[j][i] = true;
                        ans++;
                    }
                }
            }
            return ans;
        }
    }
}
