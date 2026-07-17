class Solution:
    def isValid(self, s: str) -> bool:
        stack = []

        if not len(s)%2==0:
            return False

        for char in s:

            if char =="(":
                stack.append(")")
            elif char =="{":
                stack.append("}")
            elif char =="[":
                stack.append("]")

            else:
                if len(stack) == 0:
                    return False 
                top_element = stack[-1]
                if top_element==char:
                    stack.pop()
                else:
                    return False
        if len(stack) > 0:
            return False  
        return True