class Solution:
    def isPalindrome(self, s: str) -> bool:
    
        right = len(s)-1
        left = 0
        while left < right:
            if s[left].isalnum() and s[right].isalnum():
                if s[left].lower() != s[right].lower():
                    return False
                else:
                    left+=1
                    right-=1

            if not s[left].isalnum() :
                left+=1
            if not s[right].isalnum() :
                right-=1

        return True