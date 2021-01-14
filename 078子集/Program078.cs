using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _078子集
{
    //给你一个整数数组 nums ，返回该数组所有可能的子集（幂集）。解集不能包含重复的子集。


    //示例 1：

    //输入：nums = [1,2,3]
    //输出：[[],[1],[2],[1,2],[3],[1,3],[2,3],[1,2,3]]
    //示例 2：

    //输入：nums = [0]
    //输出：[[],[0]]


    //提示：

    //1 <= nums.length <= 10
    //-10 <= nums[i] <= 10

    class Program078
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 1, 2, 3 };
            foreach (var item in Subsets(arr))
            {
                foreach (var i in item)
                {
                    Console.WriteLine(i.ToString());
                }
            }
            Console.ReadKey();
        }

        public static IList<IList<int>> Subsets(int[] nums)
        {
            var res = new List<IList<int>>();
            var subres = new List<int>();

            if (nums.Length == 0)
            {
                return res;
            }

            DFS(0, res, subres, nums);

            return res;
        }
        public static void DFS(int index, List<IList<int>> res, List<int> subres, int[] nums)
        {
            if (index == nums.Length)
            {
                res.Add(new List<int>(subres));
                return;
            }

            DFS(index + 1, res, subres, nums);

            subres.Add(nums[index]);
            DFS(index + 1, res, subres, nums);
            subres.RemoveAt(subres.Count - 1);
        }
    }
}
