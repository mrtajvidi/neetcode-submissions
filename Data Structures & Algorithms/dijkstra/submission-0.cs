public class Solution {
    // Implementation for Dijkstra's shortest path algorithm
    public Dictionary<int, int> ShortestPath(int n, List<List<int>> edges, int src) {
        var adj = new Dictionary<int, List<int[]>>();
        for (int i = 0; i < n; i++) {
            adj[i] = new List<int[]>();
        }

        // s = src, d = dst, w = weight
        foreach (var edge in edges) {
            int s = edge[0], d = edge[1], w = edge[2];
            adj[s].Add(new int[]{d, w});
        }

        // Compute shortest paths
        var shortest = new Dictionary<int, int>();
        var minHeap = new PriorityQueue<int[], int>();
        
        minHeap.Enqueue(new int[]{0, src}, 0);

        while (minHeap.Count > 0) {
            var curr = minHeap.Dequeue();
            int w1 = curr[0], n1 = curr[1];

            if (shortest.ContainsKey(n1)) continue;
            shortest[n1] = w1;

            foreach (var edge in adj[n1]) {
                int n2 = edge[0], w2 = edge[1];
                if (!shortest.ContainsKey(n2)) {
                    minHeap.Enqueue(new int[]{w1 + w2, n2}, w1 + w2);
                }
            }
        }

        for (int i = 0; i < n; i++) {
            if (!shortest.ContainsKey(i))
                shortest[i] = -1;
        }

        return shortest;
    }
}
