public class Solution {
    public int[][] KClosest(int[][] points, int k) {

        var minHeap = new PriorityQueue<int[], int>();

        foreach (var point in points)
        {
            var x = point[0];
            var y = point[1];
            var distance = (x * x + y * y);
            minHeap.Enqueue(point, -distance);
            if (minHeap.Count > k)
            {
                minHeap.Dequeue();
            }
        }

        var res = new List<int[]>();
        while (minHeap.Count > 0) {
            res.Add(minHeap.Dequeue());
        }

        return res.ToArray();    
    }
}
