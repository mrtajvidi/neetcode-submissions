public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;

        var dictS = new Dictionary<char, int>();

        foreach (var chs in s)
        {
            if (dictS.ContainsKey(chs))
            {
                dictS[chs]++;
            }
            else 
            {
                dictS[chs] = 1;
            }
        }

        foreach (var cht in t)
        {
            if (!dictS.ContainsKey(cht) || dictS[cht] == 0) return false;

            dictS[cht]--;
        }
        return true;
    }
}
