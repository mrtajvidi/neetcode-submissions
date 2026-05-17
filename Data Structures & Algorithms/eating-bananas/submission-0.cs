public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        var l = 1;
        var r = piles.Max();
        var res = l;

        while (l <= r)
        {
            var k = (l + r) / 2;

            long totalTime = 0;
            foreach (int p in piles)
            {
                totalTime += (int)Math.Ceiling((double)p / k);
            }

            if (totalTime <= h)
            {
                res = k;
                r = k - 1;
            }
            else 
            {
                l = k + 1;
            }
        }
        return res;
    }
}
