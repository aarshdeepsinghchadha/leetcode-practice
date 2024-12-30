// **Example 1:**

// **Input:** s = "()"

// **Output:** true

// **Example 2:**

// **Input:** s = "()[]{}"

// **Output:** true

// **Example 3:**

// **Input:** s = "(]"

// **Output:** false

// **Example 4:**

// **Input:** s = "([])"

// **Output:** true

// Key : make the stack empty
public class Solution{
    public bool IsValid(string s) {
        Stack<char> stack = new Stack<char>();
        Dictionary<char, char> bracketMap = new Dictionary<char, char> {
            {')', '('},
            {']', '['},
            {'}', '{'}
        }; 
        foreach(char c in s) {
            if(bracketMap.ContainsKey(c)) {
                char top = stack.Count > 0 ? stack.Pop() : '#';
                if(top != bracketMap[c]) {
                    return false;
                }
            } else {
                stack.Push(c);
            }
        }

        return stack.Count == 0;
    }
}

var solution = new Solution();
string input = "()";
bool output = solution.IsValid(input);

Console.WriteLine($"Input : {input}, Output : {output}");