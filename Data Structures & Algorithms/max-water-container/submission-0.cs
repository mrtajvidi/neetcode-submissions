public class Solution {
    public int MaxArea(int[] heights) {
        var i = 0;
        var j = heights.Length - 1;
        var maxWater = 0;

        while (i < j)
        {
            var area = (j - i) * Math.Min(heights[i], heights[j]);
            if (area > maxWater)
            {
                maxWater = area;
            }

            if (heights[i] <= heights[j]) 
            {
                i++;
            }
            else
            { 
                j--;
            }                
        }

        return maxWater;
    }
}
