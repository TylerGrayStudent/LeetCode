namespace Leetcode;

public class PascalsTriangle
{
    public class Solution
    {
        public IList<IList<int>> Generate(int numRows)
        {
            switch (numRows)
            {
                case 1:
                    return new List<IList<int>> { new List<int> { 1 } };
                case 2:
                    return new List<IList<int>> { new List<int> { 1 }, new List<int> { 1, 1 } };
            }

            var result = new List<IList<int>>{new List<int>{1}, new List<int>{1, 1,}};
            for (var i = 2; i < numRows; i++)
            {
                var newRow = new List<int> { 1 };
                for (var j = 1; j < i; j++)
                {
                    var left = result[i - 1][j - 1];
                    var right = result[i - 1][j];
                    newRow.Add(left+right);
                }
                newRow.Add(1);
                result.Add(newRow);
            }

            return result;
        }
    }
}