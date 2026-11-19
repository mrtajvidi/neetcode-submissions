class Solution:
    def subsetsWithDup(self, nums: List[int]) -> List[List[int]]:
        nums.sort()
        output = []

        def backtrack(i, substring):
            if i == len(nums):
                output.append(substring[::])
                return 
            
            substring.append(nums[i])
            backtrack(i + 1, substring)
            substring.pop()

            while i + 1 < len(nums) and nums[i + 1] == nums[i]:
                i += 1
            
            backtrack(i + 1, substring)
        

        backtrack(0, [])
        return output



