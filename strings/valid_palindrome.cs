// nput: s = "A man, a plan, a canal: Panama"
// Output: true
// Explanation: "amanaplanacanalpanama" is a palindrome.

// Input: s = "race a car"
// Output: false
// Explanation: "raceacar" is not a palindrome.



// Input: s = " "
// Output: true
// Explanation: s is an empty string "" after removing non-alphanumeric characters.
// Since an empty string reads the same forward and backward, it is a palindrome.

public class Solution {
    public bool IsPalindrome(string s) {
        int left = 0;
        int right = s.Length -1;

        while(left < right) {
            while(left < right && !Char.IsLetterOrDigit(s[left])){
                left ++;
            }

            while(left < right && !Char.IsLetterOrDigit(s[right])){
                right ++;
            }

            if(Char.ToLower(s[left]) != Char.ToLower(s[right])) {
                return false;
            }

            left ++;
            right --;
        }
        return true;
    }
}

var solution = new Solution();

var input = "A man, a plan, a canal: Panama";
var output = solution.IsPalindrome(input);

Console.WriteLine($"Input : {input}, Output: {output}");