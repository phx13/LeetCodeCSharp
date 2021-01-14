using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _048旋转图像
{
    //给定一个 n × n 的二维矩阵表示一个图像。

    //将图像顺时针旋转 90 度。

    //说明：

    //你必须在原地旋转图像，这意味着你需要直接修改输入的二维矩阵。请不要使用另一个矩阵来旋转图像。

    //示例 1:

    //给定 matrix =
    //[
    //  [1, 2, 3],
    //  [4, 5, 6],
    //  [7, 8, 9]
    //],

    //原地旋转输入矩阵，使其变为:
    //[
    //  [7,4,1],
    //  [8,5,2],
    //  [9,6,3]
    //]
    //示例 2:

    //给定 matrix =
    //[
    //  [5, 1, 9, 11],
    //  [2, 4, 8, 10],
    //  [13, 3, 6, 7],
    //  [15, 14, 12, 16]
    //], 

    //原地旋转输入矩阵，使其变为:
    //[
    //  [15,13, 2, 5],
    //  [14, 3, 4, 1],
    //  [12, 6, 8, 9],
    //  [16, 7,10,11]
    //]

    class Program048
    {
        static void Main(string[] args)
        {
            var matrix = new int[][] { new int[] { 5, 1, 9, 11 }, new int[] { 2, 4, 8, 10 }, new int[] { 13, 3, 6, 7 }, new int[] { 15, 14, 12, 16 } };
            Rotate(matrix);
        }
        public static void Rotate(int[][] matrix)
        {
            var rows = matrix.Length;
            var cols = matrix[0].Length;
            //转置
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    var temp = matrix[i][j];
                    matrix[i][j] = matrix[j][i];
                    matrix[j][i] = temp;
                }
            }
            //逐行翻转
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols / 2; j++)
                {
                    int temp = matrix[i][j];
                    matrix[i][j] = matrix[i][cols - 1 - j];
                    matrix[i][cols - 1 - j] = temp;
                }
            }
            foreach (var row in matrix)
            {
                foreach (var cell in row)
                {
                    Console.Write(cell);
                }
                Console.WriteLine("\n");
            }
            Console.ReadKey();
        }
    }
}
