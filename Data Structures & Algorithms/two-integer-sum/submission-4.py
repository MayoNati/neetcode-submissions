class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        seen={}
        for index, num in enumerate(nums):
            complement = target - num
            if num in seen:
                return [seen[num],index]
            
            seen[complement]=index