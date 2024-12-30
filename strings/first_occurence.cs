public class Solution {
    public int StrStr(string haystack, string needle) {
        if(string.IsNullOrEmpty(needle)) {
            return 0;
        }

        int index = haystack.IndexOf(needle);
        return index;
    }
}

var solution =  new Solution();
string inputHayStack = "leetcode";
string inputNeedle = "leeto";

var output = solution.StrStr(inputHayStack, inputNeedle);
Console.WriteLine($"Input Haystack : {inputHayStack} and Input needle : {inputNeedle} and Output : {output}");