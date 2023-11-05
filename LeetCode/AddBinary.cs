using System.Text;

namespace Leetcode;

public class AddBinary
{
    public class Solution {
        public string AddBinary(string a, string b)
        {
            if (a.Length > 64 || b.Length > 64)
            {
                if (a.Length > b.Length)
                {
                    b = b.PadLeft(a.Length, '0');
                }
                else
                {
                    a = a.PadLeft(b.Length, '0');
                }

                var length = a.Length;
                var sb = new StringBuilder();
                var carryOver = false;
                for (int i = length - 1; i >= 0; i--)
                {
                    var aStr = a[i].ToString();
                    var bStr = b[i].ToString();
                    if (aStr == "1" && bStr == "1")
                    {
                        sb.Insert(0, carryOver ? "1" : "0"); 
                        carryOver = true;
                    }
                    else if(aStr == "0" && bStr == "0")
                    {
                        sb.Insert(0, carryOver ? "1" : "0"); 
                        carryOver = false;
                    }
                    else
                    {
                        sb.Insert(0, carryOver ? "0" : "1"); 
                    }
                }
                if(carryOver)
                    sb.Insert(0, "1");
                return new string(sb.ToString().ToArray());
            }
            
            long valA = Convert.ToInt64(a, 2);
            long valB = Convert.ToInt64(b, 2);
            var result = valA + valB;
            return Convert.ToString(result, 2);
        }
    }
}