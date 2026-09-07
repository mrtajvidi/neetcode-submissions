class Solution:
    def longestCommonPrefix(self, strs: List[str]) -> str:
        if len(strs) == 1:
            return strs[0]
        
        strs = sorted(strs)

        min_range = min(len(strs[0]) , len(strs[-1]))

        for i in range(min_range):
            if strs[0][i] != strs[-1][i]:
                return strs[0][:i]
            
        return strs[0]