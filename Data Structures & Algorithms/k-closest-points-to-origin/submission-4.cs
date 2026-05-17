public class Solution {
    public int[][] KClosest(int[][] points, int k) {

        var maxHeap = new PriorityQueue<int[], int>();

        foreach (var point in points)
        {
            var x = point[0];
            var y = point[1];
            var distance = (x * x + y * y);
            maxHeap.Enqueue(point, -distance);
            if (maxHeap.Count > k)
            {
                maxHeap.Dequeue();
            }
        }

        var res = new List<int[]>();
        while (maxHeap.Count > 0) {
            res.Add(maxHeap.Dequeue());
        }

        return res.ToArray();    
    }
}
