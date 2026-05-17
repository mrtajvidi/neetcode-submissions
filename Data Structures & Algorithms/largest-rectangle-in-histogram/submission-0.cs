public class Solution {
    public int LargestRectangleArea(int[] heights) {
        var stack = new Stack<int[]>(); // pair: (index, height)
        var maxArea = 0;

        for (int i = 0; i < heights.Length; i++)
        {
            var curHeight = heights[i];
            var start = i;
            while (stack.Count > 0 && stack.Peek()[1] > curHeight)
            {   
                var top = stack.Pop();
                var height = top[1];
                var index = top[0];

                var area = height * (i - index);
                maxArea = Math.Max(area, maxArea);
                start = index;
            }
            stack.Push(new int[]{ start, heights[i]});
        }

        foreach (var pair in stack)
        {
            int index = pair[0];
            int height = pair[1];

            maxArea = Math.Max(maxArea, height * (heights.Length - index));
        }

        return maxArea;
    }
}
