class Solution:
    def isValid(self, s: str) -> bool:
        stack = []

        dist = {
            '(':')',
            '{':'}',
            '[':']',
        }
        if len(s)%2==1:
            return False
            
        for char in s:

            if char in dist:
                stack.append(dist[char])
            else:
                if len(stack) == 0:
                    return False 
                top_element = stack[-1]
                if top_element==char:
                    stack.pop()
                else:
                    return False

        #     if char =="(":
        #         stack.append(")")
        #     elif char =="{":
        #         stack.append("}")
        #     elif char =="[":
        #         stack.append("]")

        #     else:
        #         if len(stack) == 0:
        #             return False 
        #         top_element = stack[-1]
        #         if top_element==char:
        #             stack.pop()
        #         else:
        #             return False
        if len(stack) > 0:
            return False  
        return True