using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _020有效的括号
{
    //给定一个只包括 '('，')'，'{'，'}'，'['，']' 的字符串，判断字符串是否有效。

    //有效字符串需满足：

    //左括号必须用相同类型的右括号闭合。
    //左括号必须以正确的顺序闭合。
    //注意空字符串可被认为是有效字符串。

    class Program
    {
        static void Main(string[] args)
        {
            var s = "()";
            Console.WriteLine(IsValid(s).ToString());
            Console.ReadKey();
        }
        public static bool IsValid(string s)
        {
            if (s.Length % 2 == 1)
            {
                return false;
            }
            var map = new Dictionary<char, char>();
            map.Add(')', '(');
            map.Add(']', '[');
            map.Add('}', '{');
            var stack = new Stack<char>();
            foreach (var letter in s)
            {
                if (map.ContainsKey(letter))
                {
                    if (stack.Count == 0 || stack.Peek() != map[letter])
                    {
                        return false;
                    }
                    stack.Pop();
                }
                else
                {
                    stack.Push(letter);
                }
            }
            if (stack.Count > 0)
            {
                return false;
            }
            return true;
        }
    }
}
