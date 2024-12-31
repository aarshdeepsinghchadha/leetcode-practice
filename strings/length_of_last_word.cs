public class Solution{
    public int LengthOfLastWord(string s) {
        s = s.Trim();
        int lastSpaceIndex = s.LastIndexOf(' ');
        return s.Length - lastSpaceIndex -1;
    }
}

var solution = new Solution();
var input = "fly me to the moon";
var output = solution.LengthOfLastWord(input);
Console.WriteLine($"Input: {input}, Output: {output}");