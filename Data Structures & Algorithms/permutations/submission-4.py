class Solution:
    def permute(self, nums: List[int]) -> List[List[int]]:
        output = []
        pick = [False] * len(nums)

        def backtrack(perm):
            if len(perm) == len(nums):
                output.append(perm.copy())
                return

            for i in range(len(nums)):
                if not pick[i]: 
                    perm.append(nums[i])
                    pick[i] = True
                    backtrack(perm)
                    perm.pop()
                    pick[i] = False
            
        backtrack([])
        return output

            

