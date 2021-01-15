using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _039组合总和
{
    //给定一个无重复元素的数组 candidates 和一个目标数 target ，找出 candidates 中所有可以使数字和为 target 的组合。

    //    candidates 中的数字可以无限制重复被选取。

    //说明：

    //所有数字（包括 target）都是正整数。
    //解集不能包含重复的组合。 
    //示例 1：

    //输入：candidates = [2,3,6,7], target = 7,
    //所求解集为：
    //[
    //  [7],
    //  [2,2,3]
    //]
    //示例 2：

    //输入：candidates = [2,3,5], target = 8,
    //所求解集为：
    //[

    // [2,2,2,2],
    //  [2,3,3],
    //  [3,5]
    //]


    //提示：

    //1 <= candidates.length <= 30
    //1 <= candidates[i] <= 200
    //candidate 中的每个元素都是独一无二的。
    //1 <= target <= 500

    class Program039
    {
        static void Main(string[] args)
        {
            var candidates = new int[] { 2, 3, 5 };
            var target = 8;
            foreach (var arr in CombinationSum(candidates, target))
            {
                foreach (var cell in arr)
                {
                    Console.Write(cell + " ");
                }
                Console.Write("\n");
            }
            Console.ReadKey();
        }
        public static IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            var res = new List<IList<int>>();
            if (candidates.Length == 0)
            {
                return res;
            }
            var subres = new List<int>();
            var sum = 0;
            var index = 0;
            DFS(candidates, res, target, subres, sum, index);
            return res;
        }

        private static void DFS(int[] candidates, List<IList<int>> res, int target, List<int> subres, int sum, int index)
        {
            if (index == candidates.Length)
            {
                return;
            }
            if (sum == target)
            {
                res.Add(new List<int>(subres));
                return;
            }

            DFS(candidates, res, target, subres, sum, index + 1);

            if (sum < target)
            {
                sum += candidates[index];
                subres.Add(candidates[index]);
                DFS(candidates, res, target, subres, sum, index);
                if (index == 0)
                {
                    return;
                }
                sum -= candidates[index - 1];
                subres.RemoveAt(subres.Count - 1);
            }
        }
    }
}
