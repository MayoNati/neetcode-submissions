class Solution:
    def isValid(self, s: str) -> bool:
        stack = []

        pairs  = {
            '(':')',
            '{':'}',
            '[':']',
        }
        if len(s)%2!=0:
            return False

        for char in s:

            if char in pairs :
                stack.append(pairs [char])
            else:
                if len(stack) == 0:
                    return False 
                top_element = stack[-1]
                if top_element==char:
                    stack.pop()
                else:
                    return False
  
        return len(stack) == 0 