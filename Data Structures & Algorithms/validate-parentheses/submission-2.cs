public class Solution {
    public bool IsValid(string s) {
        var mappings = new Dictionary<char, char> {
            { ')', '(' }, { '}', '{' }, { ']', '[' }
        };

        var stack = new Stack<char>();
        foreach (var c in s)
        {
            if (mappings.ContainsKey(c))
            {
                var top = stack.Count > 0 ? stack.Pop() : '#';
                if (top != mappings[c])
                {
                    return false;
                }
            }
            else
            {
                stack.Push(c);
            }
        }
        return stack.Count == 0;

        
    }
}
