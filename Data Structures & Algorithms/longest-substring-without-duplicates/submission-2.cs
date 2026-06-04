public class Solution {
    public int LengthOfLongestSubstring(string s) {

    HashSet<char> list= new HashSet<char>();
    int max_count=0;
    int right=0;
    int left=0;
    while(right<s.Length)
    {
        if(!list.Contains(s[right])){
            list.Add(s[right]);
            right++;
            max_count=Math.Max(max_count,right - left);
        }
        else{
            list.Remove(s[left]);  
            left++;
        }
    }
    return max_count;
    }
}
