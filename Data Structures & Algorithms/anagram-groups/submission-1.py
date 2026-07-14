class Solution:
    def groupAnagrams(self, strs: List[str]) -> List[List[str]]:
        seen = {} 
        for str in strs:
            stoted_str ="".join(sorted(str)) 
            if stoted_str in seen:
                seen[stoted_str].append(str)
            else: 
                seen[stoted_str]=[str]

        result = list(seen.values())
        return result