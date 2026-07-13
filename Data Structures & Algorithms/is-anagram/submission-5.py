class Solution:
    def isAnagram(self, s: str, t: str) -> bool:
        if len(s) != len(t):
            return False

        count_arr = [0] * 26

        for cs, ct in zip(s, t):
            count_arr[ord(cs)-ord('a')]+=1
            count_arr[ord(ct)-ord('a')]-=1

        return not any(count_arr)