public class Solution {  
    Stack<char> stack = new Stack<char>();
    List<string> output = new List<string>();
    
    public List<string> GenerateParenthesis(int n) {
        BackTrack(0, 0, n);
        return output;

    }

    private void BackTrack(int openN, int closedN, int n)
    {
        if (openN == closedN && openN == n) 
        {            
            char[] charArray = stack.ToArray();
            Array.Reverse(charArray); 
            output.Add(new string(charArray));
            return;
        }

        if (openN < n)
        {
            stack.Push('(');
            BackTrack(openN + 1, closedN, n);
            stack.Pop();
        }

        if (closedN < openN)
        {
            stack.Push(')');
            BackTrack(openN, closedN + 1, n);
            stack.Pop();
        }
    }
}
