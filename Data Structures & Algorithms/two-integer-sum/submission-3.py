class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        dict={}
        for index in range(len(nums)):
            sec_sum = target - nums[index]
            if nums[index] in dict:
                return [dict[nums[index]],index]

            if sec_sum is not dict:
                dict[sec_sum]=index