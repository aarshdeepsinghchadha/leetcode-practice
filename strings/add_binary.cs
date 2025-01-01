public class Solution {
    public string AddBinary(string a, string b){
        int i = a.Length - 1;
        int j = b.Length - 1;
        int carry = 0;
        var result = new System.Text.StringBuilder();

        while( i>= 0 || j>=0 || carry > 0) {
            int bitA = i >= 0 ? a[i] - '0' : 0;
            int bitB = j >= 0 ? b[j] - '0' : 0;

            int sum = bitA + bitB + carry;

            result.Append(sum % 2);
            carry = sum/2;
            i --;
            j--;
        }

        return new string(result.ToString().Reverse().ToArray());
    }
}

var solution = new Solution();
var inputA = "1010";
var inputB = "1011";

var output = solution.AddBinary(inputA,inputB);

Console.WriteLine($"InputA: {inputA} InputB: {inputB}, Output: {output}");