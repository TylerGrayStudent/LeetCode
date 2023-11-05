namespace Leetcode;

public class PascalsTriangleII
{
    public class Solution {
        public IList<int> GetRow(int rowIndex) {
                switch (rowIndex)
                {
                    case 0:
                        return new List<int> { 1 } ;
                    case 1:
                        return new List<int> { 1, 1 };
                }

                var result = new List<IList<int>>{new List<int>{1}, new List<int>{1, 1,}};
                for (var i = 2; i <= rowIndex; i++)
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

                return result.Last();
        }
    }
}