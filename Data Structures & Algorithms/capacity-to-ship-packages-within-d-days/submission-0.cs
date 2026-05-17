public class Solution {
public int ShipWithinDays(int[] weights, int days) {
        int l = 0, r = 0;
        foreach (int w in weights) {
            l = Math.Max(l, w);
            r += w;
        }
        int res = r;

        while (l <= r) {
            int cap = (l + r) / 2;
            if (CanShip(weights, days, cap)) {
                res = Math.Min(res, cap);
                r = cap - 1;
            } else {
                l = cap + 1;
            }
        }
        return res;
    }

    private bool CanShip(int[] weights, int days, int cap) {
        int ships = 1, currCap = cap;
        foreach (int w in weights) {
            if (currCap - w < 0) {
                ships++;
                if (ships > days) {
                    return false;
                }
                currCap = cap;
            }
            currCap -= w;
        }
        return true;
    }
}