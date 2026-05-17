public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        //var inverseComparer = Comparer<int>.Create((a, b) => b.CompareTo(a));
        var queue = new PriorityQueue<int[], int>();

        foreach (var point in points) 
        {
            var x = point[0];
            var y = point[1];
            var distance = x * x + y * y;

            queue.Enqueue(point, -distance);
            if (queue.Count > k)
            {
                queue.Dequeue();
            }                        
        }

        var res = new List<int[]>();
        while (queue.Count > 0) {
            res.Add(queue.Dequeue());
        }
        
        return res.ToArray();
    }
}
