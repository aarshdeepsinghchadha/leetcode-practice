// Given an array of string words, return all strings in words that is a substring of another word. You can return the answer in any order.

// A substring is a contiguous sequence of characters within a string

 

// Example 1:

// Input: words = ["mass","as","hero","superhero"]
// Output: ["as","hero"]
// Explanation: "as" is substring of "mass" and "hero" is substring of "superhero".
// ["hero","as"] is also a valid answer.
// Example 2:

// Input: words = ["leetcode","et","code"]
// Output: ["et","code"]
// Explanation: "et", "code" are substring of "leetcode".
// Example 3:

// Input: words = ["blue","green","bu"]
// Output: []
// Explanation: No string of words is substring of another string.


public class Solution{
    public IList<string> StringMatching(string[] words) {
        var result = new List<string>();

        for(int i = 0; i < words.Length; i++){
            for(int j =0; j < words.Length; j ++){
                if(i != j && words[j].Contains(words[i])){
                    result.Add(words[i]);
                    break;
                }
            }
        }

        return result;
    }
}


var solution = new Solution();
var input  = new string[] { "mass", "as", "hero", "superhero" };
var output = solution.StringMatching(input);

Console.WriteLine($"Input: [{string.Join(", ", input)}]");
Console.WriteLine($"Output: [{string.Join(", ", output)}]");