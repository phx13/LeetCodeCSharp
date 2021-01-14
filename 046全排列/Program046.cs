using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _046全排列
{
    //给定一个 没有重复 数字的序列，返回其所有可能的全排列。

    //示例:

    //输入: [1,2,3]
    //输出:
    //[
    //  [1,2,3],
    //  [1,3,2],
    //  [2,1,3],
    //  [2,3,1],
    //  [3,1,2],
    //  [3,2,1]
    //]

    class Program046
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 1, 2, 3, 4 };
            foreach (var l in Permute(arr))
            {
                foreach (var item in l)
                {
                    Console.Write(item);
                }
                Console.Write("\n");
            }
            Console.ReadKey();
        }
        public static IList<IList<int>> Permute(int[] nums)
        {
            var res = new List<IList<int>>();
            var subres = new List<int>();
            if (nums.Length == 0)
            {
                return res;
            }
            var dict = new bool[nums.Length];
            DFS(nums, 0, res, subres, dict);
            return res;
        }

        private static void DFS(int[] nums, int index, List<IList<int>> res, List<int> subres, bool[] dict)
        {
            if (index == nums.Length)
            {
                res.Add(new List<int>(subres));
                return;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (!dict[i])
                {
                    dict[i] = true;
                    subres.Add(nums[i]);
                    DFS(nums, index + 1, res, subres, dict);
                    dict[i] = false;
                    subres.RemoveAt(subres.Count - 1);
                }
            }
        }
    }
}
