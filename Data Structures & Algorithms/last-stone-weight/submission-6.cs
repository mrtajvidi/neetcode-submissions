public class Solution {
    public int LastStoneWeight(int[] stones) {
        var queue = new PriorityQueue<int, int>();

        foreach (int stone in stones)
        {
            queue.Enqueue(-stone, -stone);
        }       

        while (queue.Count > 1)
        {
            var first  = queue.Dequeue();
            var second = queue.Dequeue();

            if (second > first)
            {
                queue.Enqueue(first - second, first - second);
            }
        }
        queue.Enqueue(0, 0);
        return Math.Abs(queue.Peek());
    }
}