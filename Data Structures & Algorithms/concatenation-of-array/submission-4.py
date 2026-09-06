class Solution:
    def getConcatenation(self, nums: List[int]) -> List[int]:
        n = len(nums)
        output = [0] * 2 * n
        

        for i, num in enumerate(nums):
            output[i] = output[i + n] = num
        
        return output
        