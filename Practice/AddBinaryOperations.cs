using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class AddBinaryOperations
    {
        public void ProcessAndPrintAddBinary()
        {
            string s1 = "1010";
            string s2 = "1011";
            string output1 = AddBinary(s1, s2);

            Console.WriteLine($"Input s1: {s1} and s2L {s2}, Output: {output1}");
        }
        private string AddBinary(string a, string b)
        {
            int i = a.Length - 1;
            int j = b.Length - 1;
            int carry = 0;
            var result = new System.Text.StringBuilder();

            while (i >= 0 || j >= 0 || carry > 0)
            {
                int bitA = i >= 0 ? a[i] - '0' : 0;
                int bitB = j >= 0 ? b[j] - '0' : 0;

                int sum = bitA + bitB + carry;

                result.Append(sum % 2);
                carry = sum / 2;
                i--;
                j--;
            }

            return new string(result.ToString().Reverse().ToArray());
        }
    }
}
