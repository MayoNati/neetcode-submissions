public class Solution {
    public int FindMin(int[] nums) {
        
        int r=nums.Length-1;
        int l=0;
        if(nums.Length==2){
            return Math.Min(nums[l],nums[r]);
        }
        while(l<r){
            int mid=l + (r - l) / 2  ;
            
            if(nums[mid]>nums[r]){
                l=mid+1;
            }
            else{
                r=mid;
            }
        }
        return nums[l];
    }
}
