using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _022括号生成
{
    //数字 n 代表生成括号的对数，请你设计一个函数，用于能够生成所有可能的并且 有效的 括号组合。

    //示例：

    //输入：n = 3
    //输出：[
    //       "((()))",
    //       "(()())",
    //       "(())()",
    //       "()(())",
    //       "()()()"
    //     ]

    class Program022
    {
        static void Main(string[] args)
        {
            var n = 3;
            foreach (var item in GenerateParenthesis(n))
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
        public static IList<string> GenerateParenthesis(int n)
        {
            var res = new List<string>();
            if (n <= 0)
            {
                return res;
            }
            var left = n;
            var right = n;
            var str = "";
            DFS(left, right, res, str);
            return res;
        }

        private static void DFS(int left, int right, List<string> res, string str)
        {
            if (left == 0 && right == 0)
            {
                res.Add(str);
                return;
            }

            if (left > 0)
            {
                str += "(";
                DFS(left - 1, right, res, str);
                str = str.Remove(str.Length - 1, 1);
            }
            if (left < right)
            {
                str += ")";
                DFS(left, right - 1, res, str);
            }
        }
    }
}
