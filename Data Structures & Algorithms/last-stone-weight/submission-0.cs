public class Solution {
    public int LastStoneWeight(int[] stones) {
        // create a max comparator
        
        // in a for loop 
            // from the array, form a max priority queue

                
        // what's left in the queue are the highest two 
        // dequeue the highest
        // dequeue the 2nd highest
        // enqueue highest - lowest
        // repeat until there is only item left in the queue 

        var inverseComparer = Comparer<int>.Create((a, b) => 0 - a.CompareTo(b));
        var heap = new PriorityQueue<int, int>(inverseComparer);

        foreach (var stone in stones)
        {
            heap.Enqueue(stone, stone);
        }    

        while (heap.Count > 1)
        {
            var stone1 = heap.Dequeue();
            var stone2 = heap.Dequeue();

            if (stone1 != stone2)
            {
                heap.Enqueue(stone1-stone2, stone1-stone2);
            }
        }

        return heap.Count > 0 ? heap.Dequeue() : 0;
    }
}
