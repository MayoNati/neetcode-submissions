public class Solution {
    public bool hasDuplicate(int[] nums) {
        
        Dictionary<int,int> dic1 = new Dictionary<int,int>();
        for(int i=0;i<nums.Length;i++)
        {
            if(dic1.Keys.Contains(nums[i]))
            {
                return true;
            }
            else
            {
                dic1.Add(nums[i],0);
            }
        }
        return false;
    }
}