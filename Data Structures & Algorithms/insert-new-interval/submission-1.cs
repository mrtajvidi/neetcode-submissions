public class Solution {
    public int[][] Insert(int[][] intervals, int[] newInterval) {
        int n = intervals.Length, i = 0;
        List<int[]> res = new List<int[]>();

        while (i < n && intervals[i][1] < newInterval[0])
        {
            res.Add(intervals[i]);
            i++;
        }

        while (i < n && intervals[i][0] <= newInterval[1])
        {   
            newInterval[0] = Math.Min(intervals[i][0], newInterval[0]);
            newInterval[1] = Math.Max(intervals[i][1], newInterval[1]);
            i++;
        }

        res.Add(newInterval);

        while (i < n)
        {
            res.Add(intervals[i]);
            i++;
        }

        return res.ToArray();
    }
}
