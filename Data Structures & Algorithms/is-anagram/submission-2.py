class Solution:
    def isAnagram(self, s: str, t: str) -> bool:
        my_dict = {}

        for c in s:
            if c in my_dict:
                my_dict[c] +=1
            else: 
                my_dict[c] = 1
        
        for c in t:
            if c in my_dict:
                my_dict[c] -= 1
            else:
                return False

        
        for val in my_dict.values():
            if val != 0: 
                return False
        
        return True