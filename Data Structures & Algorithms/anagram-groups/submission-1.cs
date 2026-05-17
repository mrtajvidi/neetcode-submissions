public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var res = new Dictionary<string, List<string>>();

        foreach (var str in strs)
        {
            int[] count = new int[26];

            foreach (char c in str)
            {
                count[c - 'a']++;
            }

            var word = string.Join(',', count);
            if (!res.ContainsKey(word)){
                res[word] = new List<string>();
            }
            res[word].Add(str);
        }

        return res.Values.ToList<List<string>>();
    }
}
