// Input: strs = ["flower","flow","flight"]
// Output: "fl"

public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if(strs == null || strs.Length == 0) {
            return "";
        }

        string prefix = strs[0]; // flower

        for(int i =1; i < strs.Length; i ++) { //flow
            while(strs[i].IndexOf(prefix) != 0) { // is flow != flower = true
                prefix = prefix.Substring(0, prefix.Length - 1); // flower -> flowe , flowe -> flow , flow == flow then cut

                if(prefix == "") {
                    return "";
                }
            }
        }

        return prefix;
    }
}

var solution = new Solution();

string[] input = { "flower", "flow", "flight" };
string output = solution.LongestCommonPrefix(input);

Console.WriteLine("Example 1:");
Console.WriteLine($"Input: {string.Join(", ", input)}");
Console.WriteLine($"Output: {output}");
