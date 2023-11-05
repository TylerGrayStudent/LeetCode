namespace Leetcode;

public class PascalsTriangle
{
    public class Solution
    {
        public IList<IList<int>> Generate(int numRows)
        {
            if (numRows == 1) return new List<IList<int>> { new List<int> { 1 } };

            if (numRows == 2) return new List<IList<int>> { new List<int> { 1 }, new List<int> { 1, 1 } };

            var result = new List<IList<int>> { new List<int> { 1 }, new List<int> { 1, 1 } };
            for (var i = 2; i <= numRows; i++)
            {
                var newRow = new List<int>();
                for (var j = 0; j < i+1; j++)
                {
                    var left = 0;
                    var right = 0;
                    try
                    {
                        left = result[i - 1][j];
                    }
                    catch (Exception e)
                    {
                        //
                    }
                    try
                    {
                        
                        right = result[i - 1][j - 1];
                    }
                    catch (Exception e)
                    {
                        //
                    }

                    var val = left + right;
                    newRow.Add(val);
                }

                result.Add(newRow);
            }

            return result;
        }
    }
}