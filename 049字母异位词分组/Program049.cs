using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _049字母异位词分组
{
    //给定一个字符串数组，将字母异位词组合在一起。字母异位词指字母相同，但排列不同的字符串。

    //示例:

    //输入: ["eat", "tea", "tan", "ate", "nat", "bat"]
    //输出:
    //[
    //  ["ate","eat","tea"],
    //  ["nat","tan"],
    //  ["bat"]
    //]
    //说明：

    //所有输入均为小写字母。
    //不考虑答案输出的顺序。

    class Program049
    {
        static void Main(string[] args)
        {
            var strs = new string[] { "eat", "tea", "tan", "ate", "nat", "bat" };
            foreach (var list in GroupAnagrams(strs))
            {
                foreach (var word in list)
                {
                    Console.Write(word + " ");
                }
                Console.Write("\n");
            }
            Console.ReadKey();
        }
        public static IList<IList<string>> GroupAnagrams(string[] strs)
        {
            //散列表
            var res = new List<IList<string>>();
            var dict = new Dictionary<string, List<string>>();
            foreach (var word in strs)
            {
                var keyArray = word.ToArray();
                Array.Sort(keyArray);
                var key = string.Join("", keyArray);
                if (dict.ContainsKey(key))
                {
                    dict[key].Add(word);
                }
                else
                {
                    dict.Add(key, new List<string>() { word });
                }
            }
            foreach (var list in dict.Values)
            {
                res.Add(list);
            }
            return res;
        }
    }
}
