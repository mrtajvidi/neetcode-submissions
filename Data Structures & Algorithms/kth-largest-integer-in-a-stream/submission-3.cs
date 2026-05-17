public class KthLargest {
    private PriorityQueue<int, int> queue;
    private readonly int size;

    public KthLargest(int k, int[] nums) {
        this.size = k;
        this.queue = new PriorityQueue<int, int>();

        foreach (var num in nums)
        {
            queue.Enqueue(num, num);
        }
    }
    
    public int Add(int val) {
        
        queue.Enqueue(val, val);
        while (queue.Count > size)
        {
            queue.Dequeue();
        }
        return queue.Peek();
    }
}
