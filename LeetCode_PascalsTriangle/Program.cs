using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_PascalsTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            var answer = solution.Generate(4);
            foreach (var row in answer)
            {
                foreach (var i in row)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine();
            }
        }
    }

    public class Solution
    {
        public IList<IList<int>> Generate(int numRows)
        {
            var result = new int[numRows][];
            if (numRows < 1) return result;

            result[0] = new int[1] { 1 };
            if (numRows < 2) return result;

            for (var i = 1; i < numRows; i++)
            {
                var row = new int[i + 1];
                row[0] = result[i - 1][0];
                for (var j = 1; j < row.Length - 1; j++)
                {
                    row[j] = result[i - 1][j - 1] + result[i - 1][j];
                }
                row[row.Length - 1] = result[i - 1][result[i - 1].Length - 1];
                result[i] = row;
            }

            return result;
        }
    }

}
