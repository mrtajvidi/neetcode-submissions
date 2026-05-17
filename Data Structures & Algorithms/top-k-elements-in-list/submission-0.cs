public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        // create a dictionary with key the num and value its frequency
        // O(n)
        var dict = new Dictionary<int, int>();
        foreach(var num in nums)
        {
            if (dict.ContainsKey(num))
            {
                dict[num]++;
            }
            else
            {
                dict[num] = 1;
            }
        }

        // min heap 
        var queue = new PriorityQueue<int, int>();
        foreach(var key in dict.Keys)
        {
            queue.Enqueue(key, dict[key]);
            if (queue.Count > k)
                queue.Dequeue();            
        }

        var output = new int[k];
        for (int i = 0; i < k; i++)
        {
            var temp = queue.Dequeue();
            Console.WriteLine($"temp is {temp}");
            output[i] = temp;
        }
        return output;

        // iterate through the dict and create a min priority queue
        // the priority is the frequency
        // anytime time the count of enqueue goes above k, dequeue the lowest
        // at the end of for loop, we have a priority queue with only 2 elements  
        // O(n) for the loop 
        // O(log(n)) for dequeue/enqueue
        // O(n)
    }
}
