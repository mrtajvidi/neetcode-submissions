public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var res = new Dictionary<string, List<string>>();
        foreach (var s in strs)
        {
            var count = new int[26];
            foreach (var c in s)
            {
                count[c - 'a']++;
            }
            var key = string.Join(",", count);
            if (!res.ContainsKey(key))
            {
                res[key] = new List<string>();
            }
            res[key].Add(s);
        }

        return res.Values.ToList<List<string>>();
    }
}
