class Solution:
    def combinationSum(self, nums: List[int], target: int) -> List[List[int]]:
        output = []

        def dfs(idx, total, currentList):
            if total == target: 
                output.append(currentList.copy())
                return
            
            if idx >= len(nums) or total > target:
                return 
            
            currentList.append(nums[idx])
            total += nums[idx]

            dfs(idx, total, currentList)
            
            currentList.pop()
            total -= nums[idx]
            dfs(idx + 1, total, currentList)
            return
        
        dfs(0, 0, [])
        return output
        

            

