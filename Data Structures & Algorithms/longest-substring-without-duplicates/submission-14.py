class Solution:
    def lengthOfLongestSubstring(self, s: str) -> int:
        max_path=0
        right = 0
        left = 0
        seen=set() 
        while right < len(s):
            if not s[right] in seen:
                seen.add(s[right])

            elif s[left]==s[right]:
                left+=1                        
            else:     
                left=right
                seen=set()
                seen.add(s[right]) 

            if max_path < len(seen):
                max_path=len(seen)  
            right+=1

        return max(max_path,len(seen))