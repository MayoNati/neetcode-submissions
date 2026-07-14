class Solution:
    def groupAnagrams(self, strs: List[str]) -> List[List[str]]:
        seen = {} 
        
        for str in strs:
            sorted_str ="".join(sorted(str))
            seen.setdefault(sorted_str,[]).append(str)

        result = list(seen.values())
        return result