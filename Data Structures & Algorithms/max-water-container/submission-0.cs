public class Solution {
    public int MaxArea(int[] heights) {
        
        int right=heights.Length-1;
        int left=0;
        int max_area=0;


        while(left<right)
        {
            int current_area=((right-left)*Math.Min(heights[left],heights[right]));
            max_area=Math.Max(max_area,current_area);
            if(heights[left]<heights[right]){
                left++;
            }
            else{
                right--;
            }
        }
       return max_area;
    }
}
