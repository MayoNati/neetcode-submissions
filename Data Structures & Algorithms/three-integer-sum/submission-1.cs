public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        List<List<int>> result= new List<List<int>>();
        int a=nums[0]-1;
        for(int i=0;i<nums.Length;i++){
            if(a!=nums[i] || i == 0){
                a=nums[i];
                int low=i+1;
                int high=nums.Length-1;
                while(low<high){
                    int number = nums[low]+nums[high]+a;
                    if(number==0)
                    {
                        result.Add(new List<int>{a,nums[low],nums[high]});
                        low++;
                        high--; 
                        while(low < high && nums[low] == nums[low - 1]) {
                            low++;
                        }
                        while(low < high && nums[high]==nums[high+1]){
                            high--;
                        }
                    }
                    
                    if(number<0){
                        low++;
                    }
                    else if(number>0){
                        high--;                
                    }
                }
            }
        }
        return result;
    }
}
