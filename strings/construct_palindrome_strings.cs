public class Solution {
    public bool CanConstruct(string s, int k) {
        if (k > s.Length) return false;

        var charCount = new Dictionary<char, int>();
        foreach (var c in s) {
            if (!charCount.ContainsKey(c)) {
                charCount[c] = 0;
            }
            charCount[c]++;
        }

        int oddCount = 0;
        foreach (var count in charCount.Values) {
            if (count % 2 != 0) {
                oddCount++;
            }
        }

        return oddCount <= k;
    }
}

