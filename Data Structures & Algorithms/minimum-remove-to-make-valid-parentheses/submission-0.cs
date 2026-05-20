public class Solution {
    public string MinRemoveToMakeValid(string s) {

        var arr = s.ToCharArray();
        var stack = new Stack<int>();
        for (int i = 0; i < s.Length; i++)
        {
            if (arr[i] == '('){
                stack.Push(i);
            }
            else if (arr[i] == ')')
            {
                if (stack.Count > 0)
                {
                    stack.Pop();
                }
                else
                {
                    arr[i] = '\0';
                }
            }
        }

        while (stack.Count > 0)
        {
            arr[stack.Pop()] = '\0';
        }

        var result = new StringBuilder();
        foreach (var c in arr)
        {
            if (c != '\0')
            {
                result.Append(c);
            }
        }
        return result.ToString();
        
    }
}
