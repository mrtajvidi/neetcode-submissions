class Solution:
    def subsetXORSum(self, nums: List[int]) -> int:
        res = 0
        
        def dfs(i, subset):
            nonlocal res
            xorr = 0

            for num in subset: 
                xorr ^= num
            res += xorr

            for j in range(i, len(nums)):
                subset.append(nums[j])
                dfs(j + 1, subset)
                subset.pop()

            
        dfs(0, [])
        return res
            