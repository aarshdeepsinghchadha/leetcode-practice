// SymbolValue
// I             1
// V             5
// X             10
// L             50
// C             100
// D             500
// M             1000

// example 1 :
// Input: s = "III"
// Output: 3
// Explanation: III = 3.


public class Solution {
    public int RomanToInt(string s) {
        var romanToIntMap = new Dictionary<char, int>{
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

        int total = 0;
        int prevValue = 0;

        for(int i = s.Length - 1; i >= 0; i--) {
            char currentChar = s[i];
            int currentValue = romanToIntMap[currentChar];

            if(currentValue < prevValue) {
                total -= currentValue;
            } else {
                total += currentValue;
            }

            prevValue = currentValue;
        }

        return total;
    }
}

var solution = new Solution();

string input = "MCMXCIV";
int result = solution.RomanToInt(input);

Console.WriteLine($"Input : {input}, Output: {result}");